using exercise90.Models;

List<INotification> notifications = new List<INotification>
{
    new EmailNotification(),
    new SmsNotification(),
    new PushNotification()
};

foreach (var notification in notifications)
{
    notification.SendMessage("System is down!");
}
