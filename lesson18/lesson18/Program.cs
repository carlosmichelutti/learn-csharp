namespace lesson18;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText("file.txt", "Hello, World");
    }
}