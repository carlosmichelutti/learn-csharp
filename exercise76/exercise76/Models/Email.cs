namespace exercise76.Models;

internal class Email : INotifiable
{
    public void SendNotification(string notification)
    {
        Console.WriteLine($"Notification \"{notification}\" sent by email.");
        return;
    }
}
