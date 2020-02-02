using System;
using Android.App;
using Android.Runtime;
using Com.Selligent.Sdk;

namespace SMXAMDROIDTemplate
{
    [Application]
    public class CustomApp : Application
    {
        public CustomApp(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
            // do any initialisation you want here (for example initialising properties)
        }

        public override void OnCreate()
        {
            
            //Initialize the Selligent Mobile SDK like this

            var url = "https://mobile.slgnt.eu/MobilePush/api/";
            var clientId = "";
            var key = "";

            SMSettings settings = new SMSettings();
            settings.WebServiceUrl = url;
            settings.ClientId = clientId;
            settings.PrivateKey = key;

            //If you want to allow in app messages management, set this value
            settings.InAppMessageRefreshType = SMInAppRefreshType.Minutely;

            //If you want to allow in app contents management, set this value
            settings.InAppContentRefreshType = SMInAppRefreshType.Minutely;

            //If you want to specify a specific lifespan for the items in the cache.
            settings.ClearCacheIntervalValue = SMClearCache.Month;

            //If you want to disable the automatic display of remote messages
            settings.RemoteMessageDisplayType = SMRemoteMessageDisplayType.Notification;

            //If you want the SDK to manage geofencing, set the following setting to true.
            //If you do not, the enable/disable geolocation methods will not do anything
            settings.ConfigureGeolocation = true;

            //Set it to true to be able to see the logs created by the Selligent Mobile SDK
            SMManager.Debug = true;

            //Do this to specify which activity will be called when clicking on a notification created after receiving a push when the app is in background
            SMManager.NotificationActivity = new MainActivity().Class;

            //Do this to specify which activity is teh main one of the app. This allows the SDK to show potentially show a dialog only on that activity (mainly for old OS versions when the user needs to update Google services or some security protocol)
            SMManager.MainActivity = new MainActivity().Class;

            SMManager.Instance.Start(settings, this);

            SMManager.Instance.SetNotificationLargeIcon(Resource.Drawable.large_logo);

            SMManager.Instance.NotificationSmallIcon = Resource.Drawable.ic_selligent_logo;

            //If you extend SMApplication, you have to use the following version:
            //SMManager.getInstance().start(settings);


            //You can specify your own icon for the notifications this way
            //SMManager.getInstance().setNotificationSmallIcon(R.drawable.your_notif_icon);



            //!!!!!The following methods are placed here as examples, they should not be called right after a start or, as a matter of fact, in an Application class!!!!!

            //If you want to disable the notifications, call this method
            //SMManager.getInstance().disableNotifications();

            //If you want to re-enable the notifications after disabling them, call this method.
            //Typically, this will be used if you want to give the user the ability to enable/disable the notifications
            //Notifications are enabled by default so you should not call this method unless a disabled was previously done.
            SMManager.Instance.EnableNotifications();

            //If you want to disable the in app messages, call this method
            //SMManager.getInstance().disableInAppMessages();

            //If you want to re-enable the in-app messages after disabling them, or change the refresh type, call this method
            //Typically, this will be used if you want to give the user the ability to enable/disable the in-app messages or change the way they are retrieved
            //In-app messages are enabled by setting a value to InAppMessageRefreshType on the SMSettings object.
            //SMManager.getInstance().enableInAppMessages(SMInAppRefreshType.Daily);

            //If you want to know if the automatic display of remote messages is enabled
            //SMRemoteMessageDisplayType displayType = SMManager.getInstance().getRemoteMessagesDisplayType();

            base.OnCreate();
        }
    }
}
           
