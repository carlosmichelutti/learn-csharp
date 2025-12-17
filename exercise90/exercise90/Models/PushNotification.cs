namespace exercise90.Models;

internal class PushNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending PUSH: {message}");
    }
}
