public class Car
{
    private int _year;
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year
    {
        get => _year;
        set
        {
            if (value < 1960 || value > 2023)
                throw new ArgumentOutOfRangeException(nameof(Year));
            _year = value;
        }
    }
    public int Speed { get; set; } = 0;
    public string DetailedDescription => $"Car model: {this.Manufacturer} {this.Model} {this._year}";

    public Car(string manufacturer, string model, int year)
    {
        Manufacturer = manufacturer;
        Model = model;
        Year = year;
    }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating...");
        do
        {
            Speed += 5;
            Console.WriteLine($"Speed {Speed} km/h...");

            if (Speed >= 100)
                break;

        } while (true);
    }

    public void Brake()
    {
        Console.WriteLine("Braking...");
        do
        {
            Speed -= 5;
            Console.WriteLine($"Speed {Speed} km/h...");

            if (Speed <= 0)
                break;

        } while (true);
    }

    public static void Honk()
    {
        Console.WriteLine("Beep Beep");
    }
}