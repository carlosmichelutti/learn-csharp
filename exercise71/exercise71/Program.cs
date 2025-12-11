using exercise71.Models;

CurrentAccount currentAccount = new CurrentAccount(3000, 30);
currentAccount.Withdraw(100);
Console.WriteLine($"Remaining balance: ${currentAccount.CalculateBalance():F2}");

SavingsAccount savingsAccount = new SavingsAccount(3000, 0.15);
Console.WriteLine($"Remaining balance: ${savingsAccount.CalculateBalance():F2}");
