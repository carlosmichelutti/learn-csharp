namespace exercise63.Models;

internal class BankAccount
{
    public int AccountNumber { get; }
    public Holder Holder { get; }
    public double Balance { get; }
    public string Password { get; }

    public BankAccount(int accountNumber, Holder holder, double balance, string password)
    {
        AccountNumber = accountNumber;
        Holder = holder;
        Balance = balance;
        Password = new string('*', 3) + password[3..^3] + new string('*', 3);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine(Holder.DetailedDescription);
        Console.WriteLine($"Balance: {Balance:F2}");
        Console.WriteLine($"Password: {Password}");
    }
}
