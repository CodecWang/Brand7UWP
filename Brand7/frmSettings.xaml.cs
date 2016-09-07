using System;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Brand7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class frmSettings : Page
    {
        public frmSettings()
        {
            this.InitializeComponent();
        }

        private async void btnInitData_Click(object sender, RoutedEventArgs e)
        {
            //设置初始化标志
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            //弹窗提醒
            var dialog = new ContentDialog()
            {
                Title = "WARNING!",
                Content = "This will discard all your gaming progress, are you sure?\np.s. If you click \"yes\", you need to restart your app!",
                Foreground = new SolidColorBrush(Colors.Red),
                PrimaryButtonText = "YES",
                SecondaryButtonText = "NO",
            };

            dialog.PrimaryButtonClick += (a, b) => { localSettings.Values["FirstStart"] = null; };
            await dialog.ShowAsync();
        }
    }
}
