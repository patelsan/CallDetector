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
	[BroadcastReceiver]
	[IntentFilter (new[]{Intent.ActionBootCompleted})]
	public class StartupReceiver: BroadcastReceiver
	{
		public override void OnReceive (Context context, Intent intent)
		{
			Intent serviceStart = new Intent (context, typeof(PhoneCallService));
			context.StartService (serviceStart);
		}
	}
}

