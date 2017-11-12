using Brand7.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
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
        string _title = "IT&TECHNOLOGY";
        bool _canBack = false;
        double _lastOffset = 0, _currentOffset = 0;
        GameHelper GameHelper = new GameHelper();
        ObservableCollection<MenuModel> MenuList = new ObservableCollection<MenuModel>();
        ObservableCollection<BrandModel> BrandList = new ObservableCollection<BrandModel>();

        public MainPage()
        {
            this.InitializeComponent();

            //自定义标题栏、手机版状态栏等
            CustomizeWindow();
            //注册绑定更新事件
            DataContextChanged += (s, e) => Bindings.Update();
            //注册系统后退键事件
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                if (_canBack)
                {
                    e.Handled = true;
                    frmMainInOrOut(false);
                    txtTitle.Text = _title;
                }
            };
            //注册窗口大小改变事件
            Window.Current.SizeChanged += (s, e) => UpdateListSize(e.Size.Width);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pgrProcess.IsActive = true;

            await GameHelper.BrandHelper.IsFirstOrNotAsync();
            //初始化菜单和品牌列表
            MenuHelper.GetMenuList(MenuList);
            //启动时加载科技品牌
            GameHelper.BrandHelper.GetBrandsByCategory(BrandCategory.Tech);
            BrandList = GameHelper.BrandHelper.BrandList;
            Bindings.Update();
            lstMenu.SelectedIndex = 5;
            UpdateListSize(ActualWidth);

            pgrProcess.IsActive = false;
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = true;
        }

        private void lstMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pgrProcess.IsActive = true;

            //根据选定菜单项获取品牌列表
            MenuModel menu = e.ClickedItem as MenuModel;
            GameHelper.BrandHelper.GetBrandsByCategory(menu.Category);
            BrandList = GameHelper.BrandHelper.BrandList;

            if (_canBack) frmMainInOrOut(false);
            svMenu.IsPaneOpen = false;
            txtTitle.Text = _title = menu.Name;
            UpdateListSize(ActualWidth);

            pgrProcess.IsActive = false;
        }

        private void lstContent_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                Image img = (Image)e.OriginalSource;
                BrandModel clickedBrand = img.DataContext as BrandModel;
                GameHelper.BrandHelper.CurrentBrand = clickedBrand;

                //跳转到选定品牌的游戏页面
                frmMain.Navigate(typeof(frmGaming), GameHelper);
                frmMainInOrOut(true);
            }
            catch (Exception) { }
        }

        private void svContent_ViewChanging(object sender, ScrollViewerViewChangingEventArgs e)
        {
            //获取滚动前的偏移量
            _lastOffset = svContent.VerticalOffset;
        }

        private void svContent_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            //获取滚动后的偏移量
            _currentOffset = svContent.VerticalOffset;

            //根据前后位移比较判断滚动方向：向上滚动，显示顶部控件；向下滚动，隐藏顶部控件
            rpTopControl.Margin = _currentOffset > _lastOffset ? new Thickness(0, -65, 0, 0) : new Thickness(15);
            bdCornerHelper.Margin = _currentOffset > _lastOffset ? new Thickness(0, 0, 0, -80) : new Thickness(0);

            //暗黑主题下更改标题栏的颜色
            if (GameHelper.ThemeModel.Theme == ElementTheme.Light) return;
            var viewTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            viewTitleBar.ButtonForegroundColor =
                 _currentOffset > _lastOffset ?
                     Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 255, 255, 255);
        }

        private void rctMask_Tapped(object sender, TappedRoutedEventArgs e)
        {
            frmMainInOrOut(false);
        }

        private void lstFeedAbout_Tapped(object sender, TappedRoutedEventArgs e)
        {
            frmMain.Navigate(typeof(frmAbout), GameHelper);
            _canBack = true;
            ((CompositeTransform)frmMain.RenderTransform).ScaleX = 1;
            ((CompositeTransform)frmMain.RenderTransform).ScaleY = 1;

            svMenu.IsPaneOpen = false;
            lstMenu.SelectedIndex = -1;
            txtTitle.Text = "SETTINGS";
        }

        private void btnCommon_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.BorderThickness = new Thickness(0);
        }

        private void bdCornerHelper_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (frmMain.SourcePageType == null || frmMain.SourcePageType == typeof(frmAbout)) return;

            bool isIn = !_canBack;
            frmMainInOrOut(isIn);
        }

        private async void btnInit_Click(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            //弹出警告提醒
            var dialog = new ContentDialog()
            {
                Content = "THIS WILL CLEAN ALL YOUR GAME DATA, ARE YOU SURE?",
                Title = "WARNING",
                PrimaryButtonText = "YES",
                SecondaryButtonText = "NO"
            };
            //按下YES弹出重启提醒
            dialog.PrimaryButtonClick += async (a, b) =>
            {
                localSettings.Values["FirstStart"] = null;
                var tip = new MessageDialog("RESTART YOUR APP TO TAKE EFFECT.");
                await tip.ShowAsync();
            };
            await dialog.ShowAsync();
        }

        private void tsTheme_Toggled(object sender, RoutedEventArgs e)
        {
            //保存主题设置
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            //默认开启暗黑模式
            if (tsTheme.IsOn) localSettings.Values["DarkMode"] = null;
            else localSettings.Values["DarkMode"] = true;

            //切换主题
            GameHelper.ThemeModel.Theme =
                GameHelper.ThemeModel.Theme == ElementTheme.Dark ?
                ElementTheme.Light : ElementTheme.Dark;

            var viewTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            //更改标题栏的按钮颜色
            viewTitleBar.ButtonForegroundColor =
                 GameHelper.ThemeModel.Theme == ElementTheme.Dark ?
                     Color.FromArgb(255, 255, 255, 255) : Color.FromArgb(255, 0, 0, 0);
        }

        private void tsCornerHelper_Toggled(object sender, RoutedEventArgs e)
        {
            //保存设置
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (tsCornerHelper.IsOn) localSettings.Values["CornerHelper"] = true;
            else localSettings.Values["CornerHelper"] = null;

            bdCornerHelper.Visibility = tsCornerHelper.IsOn ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// frmMain窗体显示或隐藏
        /// </summary>
        /// <param name="isIn">是否显示</param>
        private void frmMainInOrOut(bool isIn)
        {
            if (isIn)
            {
                frmMainIn.Begin();
                rctMaskIn.Begin();
                _canBack = true;
            }
            else
            {
                frmMainOut.Begin();
                rctMaskOut.Begin();
                _canBack = false;
            }
        }

        /// <summary>
        /// 自定义页面标题栏、手机版状态栏等
        /// </summary>
        private void CustomizeWindow()
        {
            //启动固定窗口大小
            ApplicationView.PreferredLaunchViewSize = new Windows.Foundation.Size(500, 860);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto;

            //加载上次关闭应用时的设置
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            tsCornerHelper.IsOn = localSettings.Values["CornerHelper"] == null ? false : true;
            tsTheme.IsOn = localSettings.Values["DarkMode"] == null ? true : false;
            bdCornerHelper.Visibility = tsCornerHelper.IsOn ? Visibility.Visible : Visibility.Collapsed;
            GameHelper.ThemeModel.Theme = tsTheme.IsOn ? ElementTheme.Dark : ElementTheme.Light;

            //将控件塞入标题栏
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(rctTitleBar);

            //更改标题栏的按钮颜色
            var viewTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            viewTitleBar.ButtonBackgroundColor = Colors.Transparent;
            viewTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            viewTitleBar.ButtonForegroundColor =
                 GameHelper.ThemeModel.Theme == ElementTheme.Dark ?
                     Color.FromArgb(255, 255, 255, 255) : Color.FromArgb(255, 0, 0, 0);

            //隐藏手机版顶部状态栏
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                StatusBar statusBar = StatusBar.GetForCurrentView();
                statusBar.HideAsync();
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
                item.Size = (int)currentWindowSize / split;
            }
        }
    }
}
