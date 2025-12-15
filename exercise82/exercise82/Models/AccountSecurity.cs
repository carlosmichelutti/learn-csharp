namespace exercise82.Models;

internal class AccountSecurity
{
    public bool ValidateWithdrawal(double value)
    {
        return value <= 1000;
    }
}
