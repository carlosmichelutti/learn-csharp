using exercise89.Models;

Employee employee1 = new Manager();
Employee employee2 = new Developer();

Console.WriteLine(employee1.GenerateReport());
Console.WriteLine(employee2.GenerateReport());
