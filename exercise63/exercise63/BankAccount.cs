public class BankAccount
{
    public int AccountNumber { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public string Password { get; set; }

    public BankAccount(int accountNumber, string holder, double balance, string password)
    {
        AccountNumber = accountNumber;
        Holder = holder;
        Balance = balance;
        Password = new string('*', 3) + password[3..^3] + new string('*', 3);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Holder: {Holder}");
        Console.WriteLine($"Balance: {Balance:F2}");
        Console.WriteLine($"Password: {Password}");
    }
}
