namespace exercise89.Models;

internal class Manager : Employee
{
    public override string GenerateReport()
    {
        return "Manager's report: supervises the team.";
    }
}
