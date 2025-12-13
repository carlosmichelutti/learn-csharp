namespace exercise76.Models;

internal class Sms : INotifiable
{
    public void SendNotification(string notification)
    {
        Console.WriteLine($"Notification \"{notification}\" sent by sms.");
        return;
    }
}
