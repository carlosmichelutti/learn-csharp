namespace exercise55.Models;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

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
