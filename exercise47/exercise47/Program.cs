namespace exercise47;

public class Program
{
    public static void Main()
    {
        List<string> message = new List<string> { "o", "d", "n", "u", "m", " ", "á", "l", "o" };
        message.Reverse();

        foreach(string character in message)
        {
            Console.WriteLine(character);
        }
    }
}