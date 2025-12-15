namespace exercise81.Models;

internal class Project
{
    private List<string> _tasks;
    public string Name { get; set; }
    public int NumberTasks => _tasks.Count;

    public Project(string name)
    {
        Name = name;
        _tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        _tasks.Add(task);
    }

    public void DisplayTasks()
    {
        Console.WriteLine($"Project: {Name}");
        Console.WriteLine("Tasks:");
        foreach (string task in _tasks)
        {
            Console.WriteLine($" - {task}");
        }
        Console.WriteLine($"Total: {NumberTasks} tasks");
    }
}
