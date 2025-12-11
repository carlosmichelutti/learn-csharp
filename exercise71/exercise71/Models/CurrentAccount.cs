namespace exercise71.Models;

internal class CurrentAccount : BankAccount
{
    private double _maintenanceFee { get; set; }

    public CurrentAccount(double balance, double maintenanceFee)
        : base(balance)
    {
        _maintenanceFee = maintenanceFee;
    }

    public override void Withdraw(double value)
    {
        base.Withdraw(value + _maintenanceFee);
    }
}
