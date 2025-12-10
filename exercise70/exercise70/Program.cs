using exercise70.Models;

Analyst analyst = new Analyst("Carlos", "Analyst", 3000.00, new List<string> { "Communication", "Proactivity" }, "Junior");
Console.WriteLine(analyst.DetailedDescription);

Developer developer = new Developer("Carlos", "Developer", 4500.00, new List<string> { "python", "c#" }, "Senior");
Console.WriteLine(developer.DetailedDescription);

Manager manager = new Manager("Carlos", "Manager", 10000, "Financial");
Console.WriteLine(manager.DetailedDescription);
