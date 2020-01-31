using System;
using System.Collections;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using Com.Selligent.Sdk;
using Java.Lang;
using Java.Util;
using Xamarin.Essentials;
using String = Java.Lang.String;

namespace SMXAMDROIDTemplate
{
    public class InAppContentObserver : SMObserver, AndroidX.Lifecycle.IObserver
    {
        AndroidX.Fragment.App.FragmentManager _fragmentManager;

        public InAppContentObserver(Context context, AndroidX.Fragment.App.FragmentManager fragmentManager) : base(context)
        {
            _fragmentManager = fragmentManager;
        }

        public void OnChanged(Java.Lang.Object p0)
        {
            SMInAppContentUrlFragment inAppContentUrlFragment = SMInAppContentUrlFragment.NewInstance("MAIN");
            inAppContentUrlFragment.Refresh();

            //You can check if there is content.
            if (inAppContentUrlFragment.HasContent)
            {
                AndroidX.Fragment.App.FragmentTransaction fragmentTransaction = _fragmentManager.BeginTransaction();
                fragmentTransaction.Replace(Resource.Id.main_fragment_url, inAppContentUrlFragment);
                fragmentTransaction.Commit();
            }
            else
            {
                //There is no content, so you can display something else instead of the fragment if you want.
                //You can also listen to the broadcast sent after receiving In App Contents (cf. class EventReceiver) and,
                // if there is content for this category, then display the fragment.

                //Do stuff...
            }
        }            
    }
}
