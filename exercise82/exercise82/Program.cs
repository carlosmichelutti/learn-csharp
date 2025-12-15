using exercise82.Models;

BankAccount bankAccount = new BankAccount("Carlos Eduardo", 2000);
bankAccount.WithdrawMoney(1500);
bankAccount.WithdrawMoney(700);

Console.WriteLine(bankAccount);
