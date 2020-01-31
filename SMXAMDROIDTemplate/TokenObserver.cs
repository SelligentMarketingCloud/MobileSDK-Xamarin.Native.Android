using System;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using Java.Interop;

namespace SMXAMDROIDTemplate
{
    public class TokenObserver : SMObserver, IObserver
    {

        public TokenObserver(Context context) : base(context)
        {

        }

        public void OnChanged(Java.Lang.Object p0)
        {
            string token = (string)p0;
            Context theContext;
            
            if(_context.TryGetTarget(out theContext))
            {
                Toast.MakeText(theContext, "The GCM token received is: " + token + " (liveData)", ToastLength.Short).Show();
            }
            
        }
    }
}