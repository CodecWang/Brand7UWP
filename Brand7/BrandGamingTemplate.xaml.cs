using Brand7.Models;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Brand7
{
    public sealed partial class BrandGamingTemplate : UserControl
    {
        BrandModel BrandModel { get { return DataContext as BrandModel; } }

        public BrandGamingTemplate()
        {
            this.InitializeComponent();

            DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}
