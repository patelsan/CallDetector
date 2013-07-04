using System;
using Android.App;
using Android.OS;
using Android.Telephony;
using Android.Content;

namespace CallDetector
{
	[Service]
	public class PhoneCallService: Service
	{
		public override void OnCreate ()
		{
			base.OnCreate ();
		}

		//this will not be called, however it is require to override
		public override IBinder OnBind (Intent intent)
		{
			throw new NotImplementedException ();
		}

		public override StartCommandResult OnStartCommand (Intent intent, StartCommandFlags flags, int startId)
		{
			base.OnStartCommand (intent, flags, startId);

			var callDetactor = new PhoneCallDetector (this);
			var tm = (TelephonyManager)base.GetSystemService (TelephonyService);
			tm.Listen (callDetactor, PhoneStateListenerFlags.CallState);

			return StartCommandResult.Sticky;
		}
	}
}

