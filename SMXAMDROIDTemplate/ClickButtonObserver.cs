using System;
using Android.Content;
using Android.Widget;
using AndroidX.Lifecycle;
using Com.Selligent.Sdk;

namespace SMXAMDROIDTemplate
{
    public class ClickButtonObserver : SMObserver, IObserver
    {
        public ClickButtonObserver(Context context) : base(context)
        {
        }

        public void OnChanged(Java.Lang.Object p0)
        {
            SMNotificationButton button = (SMNotificationButton)p0;
            Context theContext;

            if (_context.TryGetTarget(out theContext) && button != null)
            {
                Toast.MakeText(theContext, "The button \"" + button.Label + "\" was clicked (liveData)", ToastLength.Short).Show();
            }

        }
    }
}
