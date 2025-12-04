namespace exercise49;

public class Program
{
    public static void Main()
    {
        List<string> mainProductList = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };
        List<string> secondaryProductList = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };
        List<string> combinedLists = new List<string> (mainProductList.Concat(secondaryProductList));

        foreach (string product in combinedLists)
        {
            Console.WriteLine(product);
        }
    }
}