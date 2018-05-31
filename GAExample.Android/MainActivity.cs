using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase.Analytics;

namespace GAExample.Droid
{
    [Activity(Label = "GAExample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		FirebaseAnalytics firebaseAnalytics;

        protected override void OnCreate(Bundle bundle)
        {
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

            firebaseAnalytics = FirebaseAnalytics.GetInstance(this);

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}
