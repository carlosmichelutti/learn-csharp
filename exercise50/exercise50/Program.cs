namespace exercise50;

public class Program
{
    public static void Main()
    {
        Dictionary<string, double> studentNotes = new Dictionary<string, double>
        {
            { "Carlos", 10.0 },
            { "João", 7.25 },
            { "Ana", 5.55 },
            { "Felipe", 3.10 },
            { "Bruna", 9.3 }
        };

        foreach (KeyValuePair<string, double> student in studentNotes)
        {
            Console.WriteLine($"Student: {student.Key} - Grade: {student.Value}");
        }
    }
}
