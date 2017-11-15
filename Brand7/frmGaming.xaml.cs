using Brand7.Models;
using System;
using System.Collections.ObjectModel;
using Windows.ApplicationModel.DataTransfer;
using Windows.System;
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
        GameHelper GameHelper;
        BrandModel CurrentBrand;
        ObservableCollection<BrandModel> BrandList;

        public frmGaming()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GameHelper = e.Parameter as GameHelper;
            BrandList = GameHelper.BrandHelper.BrandList;
            //注册共享（求助）数据事件
            DataTransferManager.GetForCurrentView().DataRequested += Gaming_DataRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            DataTransferManager.GetForCurrentView().DataRequested -= Gaming_DataRequested;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentBrand = GameHelper.BrandHelper.CurrentBrand;
            fvGaming.SelectedItem = CurrentBrand;
        }

        private void Gaming_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            var deferral = args.Request.GetDeferral();

            //获取要共享的图片
            string uri = string.Format("ms-appx:///{0}", CurrentBrand.Image);
            args.Request.Data.Properties.Title = "搞不定？叫上朋友一起搞~";
            //args.Request.Data.Properties.Description = "";
            args.Request.Data.SetBitmap(Windows.Storage.Streams.RandomAccessStreamReference.CreateFromUri(new Uri(uri)));

            deferral.Complete();
        }

        private void fvGaming_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentBrand = fvGaming.SelectedItem as BrandModel;
            Bindings.Update();

            asbInput.Text = string.Empty;
            asbInput.Focus(FocusState.Keyboard);
            txtTip.Visibility = Visibility.Collapsed;
        }

        private async void asbInput_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            //输入的名称正确，设置Brand的IsFinished为True
            if (args.QueryText == string.Empty) txtMessage.Text = "你的答案去火星了吗( ╯□╰ )?";
            else if (IsAnswerRight(args.QueryText, CurrentBrand))
            {
                CurrentBrand.IsFinished = true;
                txtMessage.Text = "( •̀ ω •́ )bingo 棒!!!";
                Bindings.Update();
                //将更新后的数据保存到本地
                await GameHelper.BrandHelper.WriteBrandsToLocalAsync();
            }
            else txtMessage.Text = "( ╯□╰ )whoops 不对噢!";

            //提示动画
            MessageIn.Begin();
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

        private void MessageIn_Completed(object sender, object e)
        {
            MessageOut.Begin();
        }

        private void MessageOut_Completed(object sender, object e)
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

        private async void hlbtnWiki_Click(object sender, RoutedEventArgs e)
        {
            //跳转至百度百科词条
            Uri wiki = new Uri(string.Format("http://baike.baidu.com/search/word?word={0}", hlbtnWiki.Content));
            await Launcher.LaunchUriAsync(wiki);
        }

        /// <summary>
        /// 判断输入的答案是否正确
        /// </summary>
        /// <param name="answer">答案</param>
        /// <param name="brand">当前品牌</param>
        /// <returns></returns>
        private bool IsAnswerRight(string answer, BrandModel brand)
        {
            if (string.Compare(answer, brand.KeyName, true) == 0) return true;
            if (string.Compare(answer, brand.PlusName, true) == 0) return true;
            if (string.Compare(answer, brand.Name, true) == 0) return true;
            return false;
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

