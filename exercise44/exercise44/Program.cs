namespace exercise44;

public class Program
{
    public static void Main()
    {
        List<double> notes = new List<double> { 8.5, 6.2, 9.1, 5.8, 7.4 };

        foreach (double note in notes)
        {
            if (note >= 7.0)
            {
                Console.WriteLine($"The student with the grade of {note} is doing very well!");
            }
            else
            {
                Console.WriteLine($"The student with a grade of {note} is below average!");
            }
        }
    }
}
