using Notifications;

Notificator notificator = new Notificator();
notificator.SendEmail("This is an email", "test@test.al");
Console.WriteLine(notificator.ReceiveEmail());
notificator.SendText("This is some sms", "0691122333");
Console.WriteLine(notificator.ReceivedText());