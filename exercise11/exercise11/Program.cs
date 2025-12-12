namespace exercise11;

public class Program
{
    public static void Main()
    {
        string keyword = "c#";
        Console.Write("Type some text: ");
        string textUser = Console.ReadLine().ToLower();

        if (textUser.Contains(keyword))
        {
            Console.WriteLine("The keyword was found in the search.");
        }
        else
        {
            Console.WriteLine("The keyword was not found in the search.");
        }
    }
}
