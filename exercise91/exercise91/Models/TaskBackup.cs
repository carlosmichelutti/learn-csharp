namespace exercise91.Models;

internal class TaskBackup : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Performing system backup task...");
    }
}
