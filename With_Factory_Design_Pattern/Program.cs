
using With_Factory_Design_Pattern;


INotification objNotificationType = null;
objNotificationType=NotificationFactory.CreateNotification("Email");
objNotificationType.Send("hi");

objNotificationType = NotificationFactory.CreateNotification("SMS");
objNotificationType.Send("hi");

objNotificationType = NotificationFactory.CreateNotification("Push");
objNotificationType.Send("hi");

objNotificationType = NotificationFactory.CreateNotification("Voice");
objNotificationType.Send("hi");
