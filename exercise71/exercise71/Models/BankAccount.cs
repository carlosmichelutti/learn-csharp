namespace exercise71.Models;

internal class BankAccount
{
    protected double Balance { get; set; }

    protected BankAccount(double balance)
    {
        Balance = balance;
    }

    public virtual void Deposit(double value)
    {
        Balance += value;
    }

    public virtual void Withdraw(double value)
    {
        Balance -= value;
    }

    public virtual double CalculateBalance()
    {
        return Balance;
    }
}
