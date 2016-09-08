using Brand7.Models;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Brand7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        BrandHelper BrandHelper = new BrandHelper();
        ObservableCollection<MenuModel> MenuList = new ObservableCollection<MenuModel>();
        ObservableCollection<BrandModel> BrandList = new ObservableCollection<BrandModel>();
        double _lastOffset = 0, _currentOffset = 0;

        public MainPage()
        {
            this.InitializeComponent();

            //自定义标题栏、手机版状态栏等
            CustomizeWindow();

            //注册系统后退键事件
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                if (frmMain.Visibility == Visibility.Visible)
                {
                    e.Handled = true;
                    frmMainInOrOut(false);
                }
            };
            //注册窗口大小改变事件
            Window.Current.SizeChanged += (s, e) => { UpdateListSize(e.Size.Width); };
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pgrProcess.IsActive = true;

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            //判断是否是第一次启动
            if (localSettings.Values["FirstStart"] == null)
            {
                //第一次启动，初始化本地数据文件
                await BrandHelper.FirstStartInitDataAsync();
                localSettings.Values["FirstStart"] = true;
            }

            //初始化菜单和品牌列表
            MenuHelper.GetMenuList(MenuList);
            await BrandHelper.GetAllBrandsAsync();
            BrandHelper.BrandList.ToList().ForEach(p => BrandList.Add(p));
            lstMenu.SelectedIndex = 0;
            UpdateListSize(ActualWidth);

            pgrProcess.IsActive = false;
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void lstMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pgrProcess.IsActive = true;

            MenuModel menu = e.ClickedItem as MenuModel;

            //根据选定菜单项获取品牌列表
            BrandHelper.GetBrandsByCategory(menu.Category);
            BrandList.Clear();
            BrandHelper.BrandList.ToList().ForEach(p => BrandList.Add(p));

            if (frmMain.Visibility == Visibility.Visible)
            {
                frmMainInOrOut(false);
            }
            svMenu.IsPaneOpen = false;
            txtTitle.Text = menu.Name;
            UpdateListSize(ActualWidth);

            pgrProcess.IsActive = false;
        }

        private void gvContent_ItemClick(object sender, ItemClickEventArgs e)
        {
 
            
            BrandModel clickedBrand = e.ClickedItem as BrandModel;
            clickedBrand.IsSelected = true;

            //跳转到选定品牌的游戏页面
            frmMain.Navigate(typeof(frmGaming), BrandHelper);
            frmMainInOrOut(true);
        }

        private void btnCommon_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.BorderThickness = new Thickness(0);
        }

        private void svContent_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            _lastOffset = svContent.VerticalOffset;
        }

        private void svContent_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            _currentOffset = svContent.VerticalOffset;

            //根据前后位移比较判断滚动方向：向上滚动，显示顶部控件；向下滚动，隐藏顶部控件
            rpTopControl.Visibility = _currentOffset > _lastOffset ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <summary>
        /// 自定义页面标题栏、手机版状态栏等
        /// </summary>
        private void CustomizeWindow()
        {
            //将控件塞入标题栏
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(rctTitleBar);

            //更改标题栏的按钮颜色
            var viewTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            viewTitleBar.ButtonBackgroundColor = Colors.Transparent;
            viewTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            viewTitleBar.ButtonForegroundColor = Color.FromArgb(255, 30, 30, 30);

            //隐藏手机版顶部状态栏
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                StatusBar statusBar = StatusBar.GetForCurrentView();
                statusBar.HideAsync();
            }
        }

        private void rctMengban_Tapped(object sender, TappedRoutedEventArgs e)
        {
            frmMainInOrOut(false);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(typeof(frmSettings));
            frmMainInOrOut(true);

            svMenu.IsPaneOpen = false;
            lstMenu.SelectedIndex = -1;
            txtTitle.Text = "SETTINGS";
        }

        private void btnProgress_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(typeof(frmProgress));
            frmMainInOrOut(true);

            svMenu.IsPaneOpen = false;
            lstMenu.SelectedIndex = -1;
            txtTitle.Text = "PROGRESS";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            bool isIn = frmMain.Visibility == Visibility.Collapsed ? true : false;
            frmMainInOrOut(isIn);
        }

        private void frmMainInOrOut(bool isIn)
        {
            if (isIn)
            {
                frmMainIn.Begin();
                btnBack.Visibility = Visibility.Visible;
                rctMask.Visibility = Visibility.Visible;
            }
            else
            {
                frmMainOut.Begin();
                btnBack.Visibility = Visibility.Collapsed;
                rctMask.Visibility = Visibility.Collapsed;
            }
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
