namespace exercise43;

public class Program
{
    public static void Main()
    {
        List<int> notes = new List<int> { 4, 7, 5, 9, 6 };

        foreach (int note in notes)
        {
            if (note >= 6)
            {
                Console.WriteLine($"Grade {note} - Approved");
            }
            else
            {
                Console.WriteLine($"Grade {note} - Failed");
            }
        }
    }
}
