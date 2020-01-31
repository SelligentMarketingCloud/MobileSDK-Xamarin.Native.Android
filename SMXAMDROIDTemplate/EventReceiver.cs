using System;
using System.Collections.Generic;
using Android.Content;
using Android.Widget;
using Com.Selligent.Sdk;
using Java.Lang;
using Java.Util;
using Xamarin.Essentials;

namespace SMXAMDROIDTemplate
{
    public class EventReceiver : BroadcastReceiver
    {
        public EventReceiver()
        {
        }

        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
            Toast toast = null;

            switch (action)
            {
                case SMManager.BroadcastEventReceivedRemoteNotification:
                    string id = intent.GetStringExtra("id");
                    string title = intent.GetStringExtra("title");
                    toast = Toast.MakeText(context, "Received notification " + id + " with title \"" + title + "\"", ToastLength.Short);
                    break;

                case SMManager.BroadcastEventReceivedInAppMessage:
                    List<SMInAppMessage> messages = (List<SMInAppMessage>)intent.GetSerializableExtra(SMManager.BroadcastDataInAppMessages);
                    toast = Toast.MakeText(context, "Received " + messages.Count + " InApp messages", ToastLength.Short);
                    break;

                case SMManager.BroadcastEventReceivedInAppContents:
                    HashMap categories = (HashMap)intent.GetSerializableExtra(SMManager.BroadcastDataInAppContents);
                    StringBuilder messageBuilder = new StringBuilder();

                    foreach (IMapEntry categoryEntry in categories.EntrySet())
                    {
                        string category = (string)categoryEntry.Key;
                        int count = (int)categoryEntry.Value;

                        messageBuilder.Append(System.String.Format("\n%s : %d", category, count));
                    }
                    toast = Toast.MakeText(context, "Received contents:" + messageBuilder.ToString(), ToastLength.Short);
                    break;

                case SMManager.BroadcastEventButtonClicked:
                    SMNotificationButton button = (SMNotificationButton)intent.GetSerializableExtra(SMManager.BroadcastDataButton);
                    toast = Toast.MakeText(context, "The button \"" + button.Label + "\" was clicked", ToastLength.Short);
                    break;

                case SMManager.BroadcastEventWillDisplayNotification:
                    toast = Toast.MakeText(context, "A notification is about to be displayed", ToastLength.Short);
                    break;

                case SMManager.BroadcastEventWillDismissNotification:
                    toast = Toast.MakeText(context, "A notification is about to be dismissed", ToastLength.Short);
                    break;

                case SMManager.BroadcastEventReceivedGcmToken:
                    toast = Toast.MakeText(context, "The GCM token received is: " + intent.GetStringExtra(SMManager.BroadcastDataGcmToken), ToastLength.Short);
                    break;
            }

            if (toast != null)
            {
                toast.Show();
            }
        }
    }
}
