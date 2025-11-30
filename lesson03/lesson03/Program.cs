namespace aula03;

public class Program
{
    public static void Main()
    {
        var myName = "Carlos";
        // myName = 20; // This doesn't work because the first variable definition is of type string.
        const int myAge = 20;
        // myAge = 30; // This doesn't work because constants don't allow changes to their values ​​after they're defined.
        dynamic variable = 100.00;
        // variable = "Carlos"; // This works because dynamic will always consider the last defined data type as its primary data type.

        Console.WriteLine("My name is " + myName + " and I'm " + myAge + " years old.");
    }
}