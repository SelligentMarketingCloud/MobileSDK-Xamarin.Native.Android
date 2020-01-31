using System;
using Android.Content;
using Android.Widget;
using AndroidX.Lifecycle;

namespace SMXAMDROIDTemplate
{
    public class DisplayedMessageObserver : SMObserver, IObserver
    {
        public DisplayedMessageObserver(Context context) : base(context)
        {

        }

        public void OnChanged(Java.Lang.Object p0)
        {
            Context theContext;

            if (_context.TryGetTarget(out theContext))
            {
                Toast.MakeText(theContext, "A notification is about to be displayed (liveData)", ToastLength.Short).Show();
            }
        }
    }
}
