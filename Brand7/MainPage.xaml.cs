using Brand7.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Brand7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        BrandHelper BrandHelper;
        ObservableCollection<MenuModel> MenuList;
        ApplicationDataContainer localSettings;
        ObservableCollection<BrandModel> BrandList;
        double lastOffset, currentOffset;

        public MainPage()
        {
            this.InitializeComponent();

            CustomizeWindow();

            BrandHelper = new BrandHelper();
            MenuList = new ObservableCollection<MenuModel>();
            BrandList = new ObservableCollection<BrandModel>();
            localSettings = ApplicationData.Current.LocalSettings;

            //注册窗口大小改变事件
            Window.Current.SizeChanged += Current_SizeChanged;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pgrProcess.IsActive = true;

            //判断是否是第一次启动
            if (localSettings.Values["FirstStart"] == null)
            {
                //第一次启动，初始化本地数据文件
                await BrandHelper.FirstStartInitDataAsync();
                localSettings.Values["FirstStart"] = true;
            }

            //初始化菜单和品牌列表
            MenuHelper.GetMenuList(MenuList);
            await BrandHelper.GetAllBrandsAsync(BrandList);
            UpdateListSize(ActualWidth);

            pgrProcess.IsActive = false;
        }

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            UpdateListSize(e.Size.Width);
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            lstMenu.SelectedIndex = -1;
            txtTitle.Text = "ALL BRANDS";
            frmGame.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Collapsed;
        }

        private void lstMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            MenuModel menu = e.ClickedItem as MenuModel;

            svMenu.IsPaneOpen = false;
            txtTitle.Text = menu.Name;
            btnBack.Visibility = Visibility.Visible;
            frmGame.Visibility = Visibility.Collapsed;
            BrandHelper.GetBrandsByCategory(BrandList, menu.Category);
        }

        private void gvContent_ItemClick(object sender, ItemClickEventArgs e)
        {
            BrandModel clickedBrand = e.ClickedItem as BrandModel;
            clickedBrand.IsSelected = true;

            btnBack.Visibility = Visibility.Visible;
            frmGame.Visibility = Visibility.Visible;
            rpTopControl.Visibility = Visibility.Visible;
            frmGame.Navigate(typeof(Gaming), BrandList);
        }

        private void btnCommon_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.BorderThickness = new Thickness(0);
        }

        private void btnBack_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            btnBack.BorderThickness = new Thickness(0);
            btnBack.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void svContent_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            currentOffset = svContent.VerticalOffset;
            if (currentOffset > lastOffset)
            {
                //向下滚动，隐藏顶部控件
                rpTopControl.Visibility = Visibility.Collapsed;
            }
            else
            {
                //向上滚动，显示顶部控件
                rpTopControl.Visibility = Visibility.Visible;
            }
        }

        private void svContent_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            lastOffset = svContent.VerticalOffset;
        }

        /// <summary>
        /// 自定义标题栏
        /// </summary>
        private void CustomizeWindow()
        {
            var titleBar = CoreApplication.GetCurrentView().TitleBar;
            var view = ApplicationView.GetForCurrentView();

            //将控件塞入标题栏
            titleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(rctTitleBar);

            //更改标题栏的按钮颜色
            view.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            view.TitleBar.ButtonForegroundColor = Color.FromArgb(255, 30, 30, 30);
        }

 

        /// <summary>
        /// 更新列表中品牌的宽、高度
        /// </summary>
        /// <param name="currentWindowSize">当前窗口的大小</param>
        private void UpdateListSize(double currentWindowSize)
        {
            int split;
            int number = (int)currentWindowSize / 200;
            switch (number)
            {
                case 1: case 2: split = 3; break;
                case 3: case 4: split = 4; break;
                case 5: case 6: split = 5; break;
                case 7: case 8: split = 6; break;
                default: split = 7; break;
            }

            foreach (var item in BrandList)
            {
                item.Size = currentWindowSize / split;
            }
        }
    }
}
