using exercise55.Models;

BankAccount account = new BankAccount("78901-2", 1000.00);
account.Deposit(500.00);

Console.WriteLine($"Account: {account.AccountNumber}");
Console.WriteLine($"Current balance: {account.Balance:F2}");
