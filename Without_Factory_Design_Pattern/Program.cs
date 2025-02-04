
using Without_Factory_Design_Pattern;

string notificationType = "Email";

INotification objNotificationType = null;
if (notificationType == "Email")
{
    objNotificationType = new EmailNotification();
    objNotificationType.Send("hi");
}
else if (notificationType == "SMS")
{
    objNotificationType = new SMSNotification();
    objNotificationType.Send("hi");
}
else if (notificationType == "Push")
{
    objNotificationType = new PushNotification();
    objNotificationType.Send("hi");
}
else if (notificationType == "Voice")
{
    objNotificationType = new VoiceNotification();
    objNotificationType.Send("hi");
}
