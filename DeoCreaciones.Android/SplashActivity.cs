using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DeoCreaciones.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoaoApp.Droid
{
    [Activity(Label = "DeoCreaciones",Theme= "@style/SplashTheme", Icon = "@drawable/deocreaciones",
        MainLauncher =true,NoHistory =true,
        ConfigurationChanges= ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Application.Context,
                typeof(MainActivity)));
            // Create your application here
        }
    }
}