namespace exercise90.Models;

internal class EmailNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}
