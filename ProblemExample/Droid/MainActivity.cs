using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.Content;

[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.Camera)]
[assembly: UsesPermission(Android.Manifest.Permission.Flashlight)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]

namespace ProblemExample.Droid
{
    [Activity(Label = "ProblemExample.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

			var permissions = new List<string>();

			if (ContextCompat.CheckSelfPermission(this.BaseContext, Android.Manifest.Permission.WriteExternalStorage) != Permission.Granted)
				permissions.Add(Android.Manifest.Permission.WriteExternalStorage);
			if (ContextCompat.CheckSelfPermission(this.BaseContext, Android.Manifest.Permission.Internet) != Permission.Granted)
				permissions.Add(Android.Manifest.Permission.Internet);
			if (ContextCompat.CheckSelfPermission(this.BaseContext, Android.Manifest.Permission.Flashlight) != Permission.Granted)
				permissions.Add(Android.Manifest.Permission.Flashlight);
			if (ContextCompat.CheckSelfPermission(this.BaseContext, Android.Manifest.Permission.Camera) != Permission.Granted)
				permissions.Add(Android.Manifest.Permission.Camera);

			if (permissions.Count > 0)
				RequestPermissions(permissions.ToArray(), 0);

            LoadApplication(new App());
        }
    }
}
