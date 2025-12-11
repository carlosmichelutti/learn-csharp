using exercise73.Models;

Smartphone smartphone = new Smartphone("Samsung", "A15", 1500, "Android");
Console.WriteLine(smartphone.DisplayInformation());
Console.WriteLine();

Laptop laptop = new Laptop("Dell", "Inspiron 15", 4000.00, "Windows");
Console.WriteLine(laptop.DisplayInformation());
Console.WriteLine();

Tablet tablet = new Tablet("Samsung", "Galaxy Tab S10", 3000.00, "Immersive");
Console.WriteLine(tablet.DisplayInformation());
Console.WriteLine();
