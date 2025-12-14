using exercise80.Models;

Employee employee = new Employee("Carlos Eduardo", 2000);
Console.WriteLine(employee);

employee.AdjustSalary(1500);
employee.AdjustSalary(5000);

Console.WriteLine(employee);
