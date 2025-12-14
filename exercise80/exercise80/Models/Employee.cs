namespace exercise80.Models;

internal class Employee
{
    public string Name { get; }
    public double Salary { get; private set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void AdjustSalary(double newSalary)
    {
        if (newSalary < Salary)
        {
            Console.WriteLine("Error: The new salary must be higher than the current one.");
        }
        else
        {
            Salary = newSalary;
        }
    }

    public override string ToString()
    {
        return $"Employee: {Name} - Current salary: ${Salary:F2}";
    }
}
