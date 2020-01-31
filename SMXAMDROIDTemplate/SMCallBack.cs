using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Com.Selligent.Sdk;
using Java.Interop;

namespace SMXAMDROIDTemplate
{
    public class SMCallBack : Java.Lang.Object, ISMCallback
    {
        public SMCallBack()
        {
        }

        public void OnError(int p0, Java.Lang.Exception p1)
        {
            Toast toast = Toast.MakeText(Application.Context, "Event sent", ToastLength.Short);
            toast.Show();
        }

        public void OnSuccess(string p0)
        {
            Toast toast = Toast.MakeText(Application.Context, "Event sent", ToastLength.Short);
            toast.Show();
        }

        
    }
}
