package calldetector;


public class PhoneCallDetector
	extends android.telephony.PhoneStateListener
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCallStateChanged:(ILjava/lang/String;)V:GetOnCallStateChanged_ILjava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("CallDetector.PhoneCallDetector, CallDetector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PhoneCallDetector.class, __md_methods);
	}


	public PhoneCallDetector ()
	{
		super ();
		if (getClass () == PhoneCallDetector.class)
			mono.android.TypeManager.Activate ("CallDetector.PhoneCallDetector, CallDetector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public PhoneCallDetector (android.content.Context p0)
	{
		super ();
		if (getClass () == PhoneCallDetector.class)
			mono.android.TypeManager.Activate ("CallDetector.PhoneCallDetector, CallDetector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onCallStateChanged (int p0, java.lang.String p1)
	{
		n_onCallStateChanged (p0, p1);
	}

	private native void n_onCallStateChanged (int p0, java.lang.String p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
