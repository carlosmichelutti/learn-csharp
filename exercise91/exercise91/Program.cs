using exercise91.Models;

List<ScheduledTask> tasks = new List<ScheduledTask>
{
    new TaskBackup(),
    new TaskReport(),
    new TaskCleaning()
};

foreach (ScheduledTask task in tasks)
{
    task.Execute();
}
