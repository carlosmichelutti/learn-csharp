namespace exercise90.Models;

internal class SmsNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
