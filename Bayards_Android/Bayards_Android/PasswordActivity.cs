using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Bayards_Android
{
    [Activity(Label = "PasswordActivity", Theme = "@android:style/Theme.DeviceDefault.Light.NoActionBar")]
    public class PasswordActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PasswordScreen);

            EditText passwordBox = FindViewById<EditText>(Resource.Id.password_text);
            Button contButton = FindViewById<Button>(Resource.Id.continuePasswordButton);
            LinearLayout warningLayout = FindViewById<LinearLayout>(Resource.Id.warningLayout);

            Repository repo = new Repository();

            contButton.Click += delegate
            {
                if (repo.sendPassword(passwordBox.Text) == true)
                {
                    warningLayout.Visibility = ViewStates.Invisible;
                    var intent = new Intent(this, typeof(AgreementActivity));
                    StartActivity(intent);
                }
                else
                {
                    passwordBox.Text = string.Empty;
                    warningLayout.Visibility = ViewStates.Visible;
                }
            };
            passwordBox.TextChanged += delegate
            {
                warningLayout.Visibility = ViewStates.Invisible;
            };


        }
    }
}