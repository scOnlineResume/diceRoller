using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Support.V4.App;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        TextView resultTextView;
        Button rollButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            rollButton = FindViewById<Button>(Resource.Id.rollButton);
            rollButton.Click += RollButton_Click;
            SupportActionBar.Title = "Lucky Number";
        }

        private void RollButton_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int luckyNumber = random.Next(seekBar.Progress) + 1;
            resultTextView.Text = luckyNumber.ToString();
        }
    }
}