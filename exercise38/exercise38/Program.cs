namespace exercise38;

public class Program
{
    public static void Main()
    {
        List<string> nameList = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
        Console.Write("Enter the student's name: ");
        string searchedName = Console.ReadLine();
        bool studentFound = false;
        int index = 0;

        while (!studentFound)
        {
            if (!(index < nameList.Count))
            {
                break;
            }

            if (nameList[index].ToUpper() == searchedName.ToUpper())
            {
                Console.WriteLine($"Student \"{searchedName}\" found in position: {index}");
                studentFound = true;
            }
            else
            {
                index++;
            }
        }

        if (!studentFound)
        {
            Console.WriteLine($"Student \"{searchedName}\" is not present on the list.");
        }
    }
}