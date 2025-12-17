namespace exercise91.Models;

internal class TaskReport : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Generating and sending daily reports...");
    }
}
