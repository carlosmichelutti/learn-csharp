Employee employee = new Employee("Carlos Pereira", "Administrative Assistant");

Console.WriteLine($"Employee: {employee.Name}");
Console.WriteLine($"Current Position: {employee.Position}");
Console.WriteLine("");

employee.Promote("Administrative Assistant");
employee.Promote("Project Analyst");

Console.WriteLine("--- After promotion ---");
Console.WriteLine($"Employee: {employee.Name}");
Console.WriteLine($"Current Position: {employee.Position}");
Console.WriteLine("");
