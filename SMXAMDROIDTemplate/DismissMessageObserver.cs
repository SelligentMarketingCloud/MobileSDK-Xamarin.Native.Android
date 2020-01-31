using System;
using Android.Content;
using Android.Widget;
using AndroidX.Lifecycle;

namespace SMXAMDROIDTemplate
{
    public class DismissMessageObserver : SMObserver, IObserver
    {
        public DismissMessageObserver(Context context) : base(context)
        {

        }

        public void OnChanged(Java.Lang.Object p0)
        {
            Context theContext;

            if (_context.TryGetTarget(out theContext))
            {
                Toast.MakeText(theContext, "A notification is about to be dismissed (liveData)", ToastLength.Short).Show();
            }           
        }
    }
}
