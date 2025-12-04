namespace exercise52;

public class Program
{
    public static void Main()
    {
        Dictionary<string, string> tasks = new Dictionary<string, string>()
        {
            { "Refactor login module", "Ana" },
            { "Testing the payments API", "Pedro" }
        };

        tasks.Clear();

        tasks.Add("Implement OAuth authentication", "João");
        tasks.Add("Optimize SQL queries", "Maria");
        tasks.Add("Update documentation", "Carlos");

        Console.WriteLine("Tasks for the next sprint:");
        foreach (KeyValuePair<string, string> task in tasks)
        {
            Console.WriteLine($"- {task.Key}: {task.Value}");
        }
    }
}