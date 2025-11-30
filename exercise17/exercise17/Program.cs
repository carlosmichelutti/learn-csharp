namespace exercise17;

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the coupon code: ");
        string coupon = Console.ReadLine();
        bool match = Regex.IsMatch(coupon, @"(^\d+$)");

        if (match)
        {
            Console.WriteLine("The coupon code is valid");
        }
        else
        {
            Console.WriteLine("The coupon code is not valid");
        }
    }
}