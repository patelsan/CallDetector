using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Telephony;
using System.Linq;
using Android.Support.V4.App;

namespace CallDetector
{
	[Activity (Label = "CallDetector", MainLauncher = true)]
	public class Status : Activity
	{
		Button startButton;
		TextView messageText;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		
			startButton = FindViewById<Button> (Resource.Id.startService);
			messageText = FindViewById<TextView> (Resource.Id.statusMessage);
			
			startButton.Click += delegate {
				Intent serviceStart = new Intent (this, typeof(PhoneCallService));
				this.StartService(serviceStart);

				SetUIState();
			};

			SetUIState ();
		}

		private void SetUIState()
		{
			bool serviceRunning = IsServiceRunning();
			startButton.Enabled = !serviceRunning;
			messageText.Text = serviceRunning ? "CallMinder service is running, its monitoring your calls." : "CallMinder service isn't running, please click button to start the srvice.";
		}

		private bool IsServiceRunning()
		{
			ActivityManager activityManager = (ActivityManager)GetSystemService (ActivityService);
			var serviceInstance = activityManager.GetRunningServices(int.MaxValue).ToList().FirstOrDefault(service => service.Service.ShortClassName.Equals("calldetector.PhoneCallService"));
			return serviceInstance != null;
		}
	}

}