namespace exercise71.Models;

internal class SavingsAccount : BankAccount
{
    private double _rateOfReturn { get; set; }

    public SavingsAccount(double balance, double rateOfReturn)
        : base(balance)
    {
        _rateOfReturn = rateOfReturn;
    }

    public override double CalculateBalance()
    {
        return base.CalculateBalance() * (1 + _rateOfReturn);
    }
}
