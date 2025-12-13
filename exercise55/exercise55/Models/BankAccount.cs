namespace exercise55.Models;

internal class BankAccount
{
    public string AccountNumber { get; }
    internal double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Deposit(double value)
    {
        Balance += value;
    }
}
