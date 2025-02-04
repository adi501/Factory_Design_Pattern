using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_Factory_Design_Pattern
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string notificationType)
        {
            INotification notification = null;

            if (notificationType == "Email")
            {
                notification = new EmailNotification();
            }
            else if (notificationType == "SMS")
            {
                notification = new SMSNotification();
            }
            else if (notificationType == "Push")
            {
                notification = new PushNotification();
            }
            else if (notificationType == "Voice")
            {
                notification = new VoiceNotification();
            }
            return notification;
        }
    }
}
