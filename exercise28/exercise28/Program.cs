namespace exercise28;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1 - Morning");
        Console.WriteLine("2 - Afternoon");
        Console.WriteLine("3 - Night");
        Console.Write("What time of day is it now? ");
        int momentDay = Convert.ToInt32(Console.ReadLine());
        Console.Write("What's your name? ");
        string nameUser = Console.ReadLine();

        string message = momentDay switch
        {
            1 => $"Good Morning, {nameUser}.",
            2 => $"Good Afternoon, {nameUser}.",
            3 => $"Good Evening, {nameUser}.",
            _ => $"Invalid code \"{momentDay}\"."
        };

        Console.WriteLine(message);
    }
}