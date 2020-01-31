using System;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using Java.Interop;

namespace SMXAMDROIDTemplate
{
    public class CustomEventObserver : SMObserver, IObserver
    {
        public CustomEventObserver(Context context) : base(context)
        {
        }

        public void OnChanged(Java.Lang.Object p0)
        {
            string evt = (string)p0;
            Context theContext;

            if (_context.TryGetTarget(out theContext))
            {
                switch (evt)
                {
                    case "CustomEvent":
                        Toast.MakeText(theContext, "Custom event triggered", ToastLength.Short).Show();
                        break;

                    case "testEventFromIAC":
                        Toast.MakeText(theContext, "You clicked in an In App Content!", ToastLength.Short).Show();
                        break;
                }
            }
        }
    }
}