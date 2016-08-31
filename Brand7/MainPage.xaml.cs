using Brand7.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        List<MenuModel> MenuList;
        ApplicationDataContainer localSettings;
        ObservableCollection<BrandModel> AllBrandList, BrandList;

        public MainPage()
        {
            this.InitializeComponent();

            BrandHelper = new BrandHelper();
            MenuList = new List<MenuModel>();
            BrandList = new ObservableCollection<BrandModel>();
            AllBrandList = new ObservableCollection<BrandModel>();
            localSettings = ApplicationData.Current.LocalSettings;

            MenuHelper.GetMenuList(MenuList);

            //更改APP标题栏的颜色
            var view = ApplicationView.GetForCurrentView();
            view.TitleBar.BackgroundColor = Color.FromArgb(100, 242, 242, 242);
            view.TitleBar.ButtonBackgroundColor = Color.FromArgb(100, 242, 242, 242);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pgrProcess.IsActive = true;

            //判断是否是第一次启动
            if (localSettings.Values["FirstStart"] == null)
            {
                //第一次启动，初始化本地Json文件
                await BrandHelper.FirstStartInitData();
                localSettings.Values["FirstStart"] = true;
            }

            await BrandHelper.GetAllBrands(BrandList);
            BrandList.ToList().ForEach(p => AllBrandList.Add(p));

            pgrProcess.IsActive = false;
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            lstMenu.SelectedIndex = -1;
            txtTitle.Text = "All Brands";
            frmGame.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Collapsed;

            BrandList.Clear();
            AllBrandList.ToList().ForEach(p => BrandList.Add(p));
        }

        private void gvContent_ItemClick(object sender, ItemClickEventArgs e)
        {
            BrandModel clickedBrand = e.ClickedItem as BrandModel;
            clickedBrand.IsSelected = true;

            btnBack.Visibility = Visibility.Visible;
            frmGame.Visibility = Visibility.Visible;
            frmGame.Navigate(typeof(Gaming), BrandList);
        }

        private void lstMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BrandCategory category;

            switch (lstMenu.SelectedIndex)
            {
                case 0: category = BrandCategory.Cater; break;
                case 1: category = BrandCategory.Technology; break;
                case 2: category = BrandCategory.Car; break;
                case 3: category = BrandCategory.AudioOrVedio; break;
                case 4: category = BrandCategory.Life; break;
                case 5: category = BrandCategory.Fashion; break;
                case 6: category = BrandCategory.University; break;
                default: category = BrandCategory.None; break;
            }

            svMenu.IsPaneOpen = false;
            txtTitle.Text = category.ToString();
            btnBack.Visibility = Visibility.Visible;
            frmGame.Visibility = Visibility.Collapsed;
            BrandHelper.GetBrandsByCategory(BrandList, category);
        }

        private void btnHamburger_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            btnHamburger.BorderThickness = new Thickness(0);
        }

        private void btnBack_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            btnBack.BorderThickness = new Thickness(0);
            btnBack.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}
