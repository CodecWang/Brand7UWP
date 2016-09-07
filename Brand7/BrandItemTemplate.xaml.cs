using Brand7.Models;
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
            sbImgScale.Begin();
            rctAnimation.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void UserControl_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            sbImgScale.Stop();
            rctAnimation.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }
    }
}
