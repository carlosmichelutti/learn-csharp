namespace exercise82.Models;

internal class BankAccount
{
    private AccountSecurity security;
    public string Holder { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string holder, double balance)
    {
        Holder = holder;
        Balance = balance;
        security = new AccountSecurity();
    }

    public void WithdrawMoney(double value)
    {
        if (!(security.ValidateWithdrawal(value)) || value > Balance)
        {
            Console.WriteLine($"Withdrawal of ${value:F2} denied.");
        }
        else
        {
            Balance -= value;
        }
    }

    public override string ToString()
    {
        return $"Holder: {Holder} - Balance: ${Balance:F2}";
    }
}
