namespace exercise13;

public class Program
{
    public static void Main()
    {
        Console.Write("Type some text: ");
        string textUser = Console.ReadLine();
        Console.Write("Which word do you want to replace? ");
        string replaceWord = Console.ReadLine();
        Console.Write($"What word do you want to replace \"{replaceWord}\" with? ");
        string substituteWord = Console.ReadLine();
        string manipulatedPhrase = textUser.Replace(replaceWord, substituteWord);

        Console.WriteLine(manipulatedPhrase);
    }
}
