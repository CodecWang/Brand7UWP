using Brand7.Models;
using System;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.Storage;
using Windows.System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Brand7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class frmAbout : Page
    {
        GameHelper GameHelper;

        public frmAbout()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GameHelper = e.Parameter as GameHelper;
        }

        private async void btnEmail_Click(object sender, RoutedEventArgs e)
        {
            var deviceInfo = new EasClientDeviceInformation();
            string mailto = "ex2tron@outlook.com";
            string subject = "Brand7 UWP REPORTS";
            string body =
                $"DEVICE:{deviceInfo.FriendlyName}," +
                $"OS:{deviceInfo.OperatingSystem}," +
                $"HARDWARE:{deviceInfo.SystemHardwareVersion}";
            Uri mailUri = new Uri(string.Format("mailto:{0}?subject={1}&body={2}", mailto, subject, body));
            await Launcher.LaunchUriAsync(mailUri);
        }

        private async void btnBlog_Click(object sender, RoutedEventArgs e)
        {
            Uri blogUri = new Uri("http://ex2tron.top");
            await Launcher.LaunchUriAsync(blogUri);
        }               
    }
}
