namespace exercise91.Models;

internal class TaskCleaning : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Cleaning up temporary server files...");
    }
}
