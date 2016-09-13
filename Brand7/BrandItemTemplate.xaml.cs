using Brand7.Models;
using Windows.System.Profile;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Brand7
{
    public sealed partial class BrandItemTemplate : UserControl
    {
        BrandModel BrandModel { get { return DataContext as BrandModel; } }

        public BrandItemTemplate()
        {
            this.InitializeComponent();

            DataContextChanged += (s, e) => Bindings.Update();
        }

        private void UserControl_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            //手机版不显示缩放动画
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile") return;

            sbImgScaleIn.Begin();
            gdBrand.Opacity = 0.3;
        }

        private void UserControl_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            //手机版不显示缩放动画
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile") return;

            sbImgScaleOut.Begin();
            gdBrand.Opacity = 1;
        }
    }
}
