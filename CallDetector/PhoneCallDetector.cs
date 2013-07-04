using System;
using Android.Telephony;
using Android.Support.V4.App;
using Android.App;
using Android.Content;

namespace CallDetector
{
	public class PhoneCallDetector: PhoneStateListener
	{
		Context context;

		public PhoneCallDetector(Context context_)
		{
			this.context = context_;
		}

		public override void OnCallStateChanged (CallState state, string incomingNumber)
		{
			if (state == CallState.Ringing) {
				ShowNotification("Incommming call detected from " + incomingNumber);
				base.OnCallStateChanged (state, incomingNumber);
			}
		}

		private void ShowNotification(string message)
		{
			NotificationCompat.Builder builder = new NotificationCompat.Builder(this.context)
				.SetContentTitle("CallMinder detected call")
					.SetSmallIcon(Android.Resource.Drawable.SymActionCall)
					.SetContentText(message);

			NotificationManager notificationManager = (NotificationManager) this.context.GetSystemService(Context.NotificationService);
			notificationManager.Notify(101, builder.Build());
		}
	}
}

