using Brand7.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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
    public sealed partial class Gaming : Page
    {
        BrandHelper BrandHelper;
        BrandModel CurrentBrand;
        ObservableCollection<BrandModel> BrandList;

        public Gaming()
        {
            this.InitializeComponent();

            BrandHelper = new BrandHelper();
            CurrentBrand = new BrandModel();
            BrandList = new ObservableCollection<BrandModel>();
        }

        /// <summary>
        /// 接收从上一页传过来的参数
        /// </summary>
        /// <param name="e">页面参数</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BrandList = (ObservableCollection<BrandModel>)e.Parameter;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //根据IsSelected获取当前的Brand
            CurrentBrand = BrandList.FirstOrDefault(p => p.IsSelected == true);
            fvGaming.SelectedIndex = BrandList.IndexOf(CurrentBrand);
            CurrentBrand.IsSelected = false;
        }

        private void fvGaming_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentBrand = fvGaming.SelectedItem as BrandModel;

            tipSwitch.IsOn = false;
            asbInput.Text = string.Empty;
            Bindings.Update();
            asbInput.Focus(FocusState.Pointer);
        }

        private void asbInput_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            int count = BrandList.Count;

            //输入的名称正确，设置Brand的IsFinished为True
            if (string.Compare(args.QueryText, CurrentBrand.Name, true) == 0)
            {
                CurrentBrand.IsFinished = true;
                txtMessage.Text = "Congratulations!";
                Bindings.Update();

                //将更新后的数据保存到本地
                BrandHelper.WriteBrandsToLocalAsync(BrandList);
            }
            else
            {
                txtMessage.Text = "Oh, no, Come on!";
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

