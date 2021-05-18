using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace XamButtonKeyboard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText txtClicked;
        
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtClicked = FindViewById<EditText>(Resource.Id.txtClicked);
            
            AlphabetButtons();
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        #region Alphabet Buttons //use Region to hide all this crap
        private void AlphabetButtons()
        {//bind the buttons we made to the ones on the layout
            
            Button btnA = FindViewById<Button>(Resource.Id.btnA);
            Button btnB = FindViewById<Button>(Resource.Id.btnB);
            Button btnC = FindViewById<Button>(Resource.Id.btnC);
            Button btnD = FindViewById<Button>(Resource.Id.btnD);
            Button btnE = FindViewById<Button>(Resource.Id.btnE);
            Button btnF = FindViewById<Button>(Resource.Id.btnF);
            Button btnG = FindViewById<Button>(Resource.Id.btnG);
            Button btnH = FindViewById<Button>(Resource.Id.btnH);
            Button btnI = FindViewById<Button>(Resource.Id.btnI);
            Button btnJ = FindViewById<Button>(Resource.Id.btnJ);
            Button btnK = FindViewById<Button>(Resource.Id.btnK);
            Button btnL = FindViewById<Button>(Resource.Id.btnL);
            Button btnM = FindViewById<Button>(Resource.Id.btnM);
            Button btnN = FindViewById<Button>(Resource.Id.btnN);
            Button btnO = FindViewById<Button>(Resource.Id.btnO);
            Button btnP = FindViewById<Button>(Resource.Id.btnP);
            Button btnQ = FindViewById<Button>(Resource.Id.btnQ);
            Button btnR = FindViewById<Button>(Resource.Id.btnR);
            Button btnS = FindViewById<Button>(Resource.Id.btnS);
            Button btnT = FindViewById<Button>(Resource.Id.btnT);
            Button btnU = FindViewById<Button>(Resource.Id.btnU);
            Button btnV = FindViewById<Button>(Resource.Id.btnV);
            Button btnW = FindViewById<Button>(Resource.Id.btnW);
            Button btnX = FindViewById<Button>(Resource.Id.btnX);
            Button btnY = FindViewById<Button>(Resource.Id.btnY);
            Button btnZ = FindViewById<Button>(Resource.Id.btnZ);
            //bind all the button clicks to a single event named ButtonClick
            btnA.Click += ButtonClick;
            btnB.Click += ButtonClick;
            btnC.Click += ButtonClick;
            btnD.Click += ButtonClick;
            btnE.Click += ButtonClick;
            btnF.Click += ButtonClick;
            btnG.Click += ButtonClick;
            btnH.Click += ButtonClick;
            btnI.Click += ButtonClick;
            btnJ.Click += ButtonClick;
            btnK.Click += ButtonClick;
            btnL.Click += ButtonClick;
            btnM.Click += ButtonClick;
            btnN.Click += ButtonClick;
            btnO.Click += ButtonClick;
            btnP.Click += ButtonClick;
            btnQ.Click += ButtonClick;
            btnR.Click += ButtonClick;
            btnS.Click += ButtonClick;
            btnT.Click += ButtonClick;
            btnU.Click += ButtonClick;
            btnV.Click += ButtonClick;
            btnW.Click += ButtonClick;
            btnX.Click += ButtonClick;
            btnY.Click += ButtonClick;
            btnZ.Click += ButtonClick;
        }
        #endregion
        #region Button Click (Fake Button)
        private void ButtonClick(object sender, EventArgs e)
        {
            //make a fake button
            Button fakeBtn = (Button)sender;

            //make the text on the button upper case and pass it to the edittext
            
            txtClicked.Text= fakeBtn.Text.ToUpper();
            //turn off the button so you can't use it again
            fakeBtn.Enabled = false;
            
        }
        #endregion
       
    }
}