
// using PartialMethodsInvoker = AppLauncher.Maui.Services.PartialMethod.AppLauncher;

namespace AppLauncher.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.Current.KeepScreenOn = true;  
        }

        private async void OnOpenAnotherAppClickAsync(object sender, EventArgs e)
        {

            //var app_launcher = new PartialMethodsInvoker();
            //app_launcher.Open(txtPackagename.Text);

            // https://play.google.com/store/apps/details?id=com.google.android.apps.nbu.paisa.user&referrer=utm_source%3Du_website&utm_medium=weblink&utm_campaign=gpay3_weblink_website_us_google_play_badge_us_nov_2020

            // https://play.google.com/store/apps/details?id=com.google.android.apps.nbu.paisa.user&hl=en&gl=US

            //https://apps.apple.com/us/app/microsoft-word/id586447913");


            // Google Wallet - https://play.google.com/store/apps/details?id=com.google.android.apps.walletnfcrel

            // packageName is in.amazon.mShop.android.shopping and appName is Amazon.

            // https://play.google.com/store/apps/details?id=com.companyname.workhorsepro&pli=1

            // gPAy - com.google.android.apps.nbu.paisa.user

            // Youtube - com.google.android.youtube
            try
            {


                //  bool launcherOpened = true; // await Launcher.Default.TryOpenAsync(txtPackagename.Text);

                // https://developer.amazon.com/docs/reports-promo/deeplink-to-the-amazon-client.html

                // amzn://apps/android?p=com.amazon.mp3&showAll=1
                bool launcherOpened = await Launcher.Default.TryOpenAsync("com.google.android.youtube://");

                // amzn://apps/android?


                //  "com.amazon.mShop.home.HomeActivity"); 
                // new Uri ("vnd.youtube://" + id)); // "com.google.android.youtube");

                // bool launcherOpened =true ; //  = await  Launcher.Default.TryOpenAsync("com.google.android.apps.nbu.paisa.user");


                if (launcherOpened)
                {
                   await   DisplayAlert("Word", "Open Ayi.", "OK");

                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }

        }

        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            string package_name = txtPackagename.Text;

            string uri = "myapp://com.expeed.app/expeed";


            bool supportsUri = await Launcher.Default.CanOpenAsync(uri);
            await DisplayAlert("Support", "supportsUri = " + supportsUri.ToString(), "OK");

            try
            {
                await Launcher.Default.OpenAsync(uri);
            }
            catch (Exception ex)                    
            {
                await DisplayAlert("No Support", ex.Message, "OK");
            }
        }

        private async void Button2_ClickAsync(object sender, EventArgs e)
        {
            string package_name = txtPackagename.Text;
            string uri = "myapp://com.companyname.sample.second.app/expeed";

            try
            {


                bool supportsUri = await Launcher.Default.CanOpenAsync(uri);
                await DisplayAlert("Support", "supportsUri = " + supportsUri.ToString(), "OK");


                await Launcher.Default.OpenAsync(uri);
            }
            catch (Exception ex)
            {
                    await DisplayAlert("No Support", ex.Message, "OK");
            }
        }
    }
}