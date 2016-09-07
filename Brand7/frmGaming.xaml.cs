using Brand7.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Brand7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class frmGaming : Page
    {
        BrandHelper BrandHelper;
        BrandModel CurrentBrand;
        ObservableCollection<BrandModel> BrandList = new ObservableCollection<BrandModel>();

        public frmGaming()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 接收从上一页传过来的参数
        /// </summary>
        /// <param name="e">页面参数</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BrandHelper = (BrandHelper)e.Parameter;
            BrandHelper.BrandList.ToList().ForEach(p => BrandList.Add(p));
            DataTransferManager.GetForCurrentView().DataRequested += Gaming_DataRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            DataTransferManager.GetForCurrentView().DataRequested -= Gaming_DataRequested;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //根据IsSelected获取当前的Brand
            CurrentBrand = BrandList.FirstOrDefault(p => p.IsSelected == true);
            fvGaming.SelectedIndex = BrandList.IndexOf(CurrentBrand);
            CurrentBrand.IsSelected = false;
        }

        /// <summary>
        /// 共享（求助）功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Gaming_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            var deferral = args.Request.GetDeferral();

            //获取要共享的图片
            string uri = string.Format("ms-appx:///{0}", CurrentBrand.Image);
            args.Request.Data.Properties.Title = "ASK FOR HELP";
            args.Request.Data.Properties.Description = "Ask friends for help.";
            args.Request.Data.SetBitmap(Windows.Storage.Streams.RandomAccessStreamReference.CreateFromUri(new Uri(uri)));

            deferral.Complete();
        }

        private void fvGaming_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentBrand = fvGaming.SelectedItem as BrandModel;
            Bindings.Update();

            asbInput.Text = string.Empty;
            txtTip.Visibility = Visibility.Collapsed;
        }

        private async void asbInput_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            //输入的名称正确，设置Brand的IsFinished为True
            if (args.QueryText == string.Empty)
            {
                txtMessage.Text = "Please input your answer!";
            }
            else if (string.Compare(args.QueryText, CurrentBrand.Name, true) == 0)
            {
                CurrentBrand.IsFinished = true;
                txtMessage.Text = "Congratulations!";
                Bindings.Update();
                //将更新后的数据保存到本地
                await BrandHelper.WriteBrandsToLocalAsync();
            }
            else
            {
                txtMessage.Text = "Come on!";
            }

            //提示动画
            SbMessage.Begin();
        }

        private void SbMessage_Completed(object sender, object e)
        {
            //提示动画结束时，若输入正确，则跳转至下一项
            if (CurrentBrand.IsFinished)
            {
                if (BrandList.IndexOf(CurrentBrand) + 1 < BrandList.Count)
                {
                    fvGaming.SelectedIndex++;
                }
            }
        }

        private void btnCommon_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.BorderThickness = new Thickness(0);
        }

        private void btnTip_Click(object sender, RoutedEventArgs e)
        {
            txtTip.Visibility = Visibility.Visible;
        }

        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI();
        }
    }

    /// <summary>
    /// 值转换器：布尔值取反转换为Visibility
    /// </summary>
    public class BoolOppositeVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value == true ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

