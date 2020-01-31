using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using AndroidX.LocalBroadcastManager.Content;
using Com.Selligent.Sdk;
using Java.Lang;
using Java.Util;

namespace SMXAMDROIDTemplate
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : SMBaseActivity, ILifecycleObserver
    {
        SMForegroundGcmBroadcastReceiver gcmReceiver;
        EventReceiver receiver;
        
        private AndroidX.Lifecycle.IObserver tokenObserver;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var test = Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);

            Button sendEventBtn = FindViewById<Button>(Resource.Id.eventBtn);
            sendEventBtn.Click += delegate
            {

                //Here is an example of sending a custom event to the Selligent Mobile Platform.
                //The method is the same for all other events, only the object passed is different.

                //You can pass some data. It can be null.
                Hashtable data = new Hashtable();
                data.Put("key1", "value 1");
                data.Put("key2", "value 2");
                data.Put("key3", "value 3");

                SMEvent evt = new SMEvent(data, new SMCallBack());
                SMManager.Instance.SendSMEvent(evt);

            };
       

            //If you use SMRemoteMessageDisplayType.Notification in the settings and have several activities, you may want to overwrite change NOTIFICATION_ACTIVITY here
            SMManager.NotificationActivity = this.Class;
           
            //Here is how you can use observers to listen to our events and replace the broadcasts
            tokenObserver = new TokenObserver(this);
            SMManager.Instance.ObserverManager.ObserveToken(this, tokenObserver);

            InAppMessageObserver inAppMessageObserver = new InAppMessageObserver(this);

            SMManager.Instance.ObserverManager.ObserveInAppMessages(this, inAppMessageObserver);

            InAppContentObserver inAppContentObserver = new InAppContentObserver(this,SupportFragmentManager);

            SMManager.Instance.ObserverManager.ObserveInAppContents(this, inAppContentObserver);

            ClickButtonObserver clickButtonObserver = new ClickButtonObserver(this);
            SMManager.Instance.ObserverManager.ObserveClickedButton(this, clickButtonObserver);


            DismissMessageObserver dismissMessageObserver = new DismissMessageObserver(this);
            SMManager.Instance.ObserverManager.ObserveDismissedMessage(this, dismissMessageObserver);

            DisplayedMessageObserver displayedMessageObserver = new DisplayedMessageObserver(this);
            SMManager.Instance.ObserverManager.ObserveDisplayedMessage(this, displayedMessageObserver);

            CustomEventObserver customEventObserver = new CustomEventObserver(this);
            SMManager.Instance.ObserverManager.ObserveEvent(this, customEventObserver);            
        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }


        public override void OnStart()
        {
            base.OnStart();

            //If you have several activities and you want the current one to be called when clicking on a notification (especially if you set AutomaticDisplayOfRemoteMessages to false),
            //use this line in your base activity
            //SMManager.NOTIFICATION_ACTIVITY = getClass();

            //In order to listen to the different local broadcasts sent by the SDK, you have to register a receiver with the LocalBroadcastManager
            /* LocalBroadcastReceiver is now deprecated with the latest version of the AndroidX libraries, so we also deprecated all pour broadcasts.
             * Although they are still sent, we recommend to migrate to observers

            if (receiver == null)
            {
                receiver = new EventReceiver();
            }
            IntentFilter filter = new IntentFilter();
            //The value set here must be the same as the one given to the CustomActionBroadcastEvent button
            filter.addAction("CustomEvent");
            //The following are the different broadcasts sent by the SDK
            filter.addAction(SMManager.BROADCAST_EVENT_RECEIVED_IN_APP_MESSAGE);
            filter.addAction(SMManager.BROADCAST_EVENT_RECEIVED_IN_APP_CONTENTS);
            filter.addAction(SMManager.BROADCAST_EVENT_RECEIVED_REMOTE_NOTIFICATION);
            filter.addAction(SMManager.BROADCAST_EVENT_WILL_DISPLAY_NOTIFICATION);
            filter.addAction(SMManager.BROADCAST_EVENT_WILL_DISMISS_NOTIFICATION);
            filter.addAction(SMManager.BROADCAST_EVENT_BUTTON_CLICKED);
            filter.addAction(SMManager.BROADCAST_EVENT_RECEIVED_GCM_TOKEN);
            LocalBroadcastManager.getInstance(this).registerReceiver(receiver, filter);
            */


            //If you want to retrieve the stored GCM Token, you can call teh following method.
            //Please note that due to the GCM registration process being asynchronous, the value returned may be empty or not up-to-date.
            //To be sure to be alerted as soon as the token changes, be sure to listen to the corresponding broadcast.
           
            //The following methods must only be executed if the activity does not extend SMBaseActivity
            if (gcmReceiver == null)
            {
                gcmReceiver = new SMForegroundGcmBroadcastReceiver(this);
            }
            RegisterReceiver(gcmReceiver, gcmReceiver.IntentFilter);

            //The following method must only be called if the activity does not extend SMBaseActivity
            SMManager.Instance.CheckAndDisplayMessage(Intent, this);

            //If you want to use geofencing, you have to enable it
            SMManager.Instance.EnableGeolocation();

            //When you want to disable geofencing (or allow the user to do it), you have to call
            SMManager.Instance.DisableGeolocation();

            //If you want to know if geofencing is enabled, simply call
            bool enabled = SMManager.Instance.IsGeolocationEnabled;
        }


        public override void OnStop()
        {
            base.OnStop();

            UnregisterReceiver(gcmReceiver);
            LocalBroadcastManager.GetInstance(this).UnregisterReceiver(receiver);
        }


        public override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            //The following method must only be called if the activity does not extend SMBaseActivity
            SMManager.Instance.CheckAndDisplayMessage(intent, this);
        }


        protected override void OnDestroy()
        {
            base.OnDestroy();

            //If you use SMRemoteMessageDisplayType.Notification in the settings and have several activities, you may want to revert NOTIFICATION_ACTIVITY here to the default one set at start
            //NB: in this template, there is only one activity, so it is useless
            SMManager.NotificationActivity = this.Class;
        }

    }
}

