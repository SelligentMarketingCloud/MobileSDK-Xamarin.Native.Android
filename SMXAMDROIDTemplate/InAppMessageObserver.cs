using System;
using System.Collections;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using Com.Selligent.Sdk;

namespace SMXAMDROIDTemplate
{
    public class InAppMessageObserver : SMObserver, IObserver
    {
        public InAppMessageObserver(Context context) : base(context)
        {

        }

        public void OnChanged(Java.Lang.Object p0)
        {

            Java.Lang.Object[] inAppMessages = (Java.Lang.Object[])p0;
           
            Context theContext;

            if(_context.TryGetTarget(out theContext) && inAppMessages != null)
            {
                foreach (SMInAppMessage message in inAppMessages)
                {
                    SMManager.Instance.DisplayMessage(message.Id, (Activity)theContext);
                }
                
            }
        }
    }
}
