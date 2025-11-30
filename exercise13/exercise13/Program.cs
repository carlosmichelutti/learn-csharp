namespace exercise13;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Type some text: ");
        string textUser = Console.ReadLine();
        Console.WriteLine("Which word do you want to replace? ");
        string replaceWord = Console.ReadLine();
        Console.WriteLine($"What word do you want to replace \"{replaceWord}\" with?");
        string substituteWord = Console.ReadLine();
        string manipulatedPhrase = textUser.Replace(replaceWord, substituteWord);

        Console.WriteLine(manipulatedPhrase);
    }
}