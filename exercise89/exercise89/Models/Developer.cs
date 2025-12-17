namespace exercise89.Models;

internal class Developer : Employee
{
    public override string GenerateReport()
    {
        return "Developer report: writes code and fixes bugs.";
    }
}
