namespace exercise30;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the book code: ");
        int bookCode = Convert.ToInt32(Console.ReadLine());

        string bookClassification = bookCode switch
        {
            >= 100 and <= 199 => "Science fiction",
            >= 200 and <= 299 => "Classical Literature",
            >= 300 and <= 399 => "Fantasy",
            >= 400 and <= 499 => "Romance",
            >= 500 and <= 599 => "Suspense/Mystery",
            >= 600 and <= 699 => "Non-fiction",
            >= 700 and <= 799 => "Biographies/memories",
            >= 800 and <= 899 => "Dystopia",
            >= 900 and <= 999 => "juvenile",
            _ => "Code doesn't exist"
        };

        Console.WriteLine(bookClassification);
    }
}
