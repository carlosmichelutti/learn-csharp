namespace exercise46;

public class Program
{
    public static void Main()
    {
        HashSet<int> scores = new HashSet<int> {};
        scores.Add(150);
        scores.Add(90);
        scores.Add(200);
        scores.Add(120);
        scores.Add(150);
        scores.Add(80);
        scores.Add(180);
        scores.Add(200);

        List<int> scoresOrdered = new List<int>(scores);
        scoresOrdered.Sort();

        Console.WriteLine("Unique scores in ascending order:");
        foreach (int score in scoresOrdered)
        {
            Console.WriteLine(score);
        }
    }
}
