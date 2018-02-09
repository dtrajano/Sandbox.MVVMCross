using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Sandbox_MVVMCross.Droid
{
    [Activity(
        Label = "Sandbox_MVVMCross"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
