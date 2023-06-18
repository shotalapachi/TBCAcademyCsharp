using Task_2;

// Creating two bank accounts
BankAccount account1 = new BankAccount();
account1.AccountNumber = "123456789";
account1.AccountHolderName = "John Doe";
account1.Currency = new Currency { amount = 1000 };
BankAccount account2 = new BankAccount();
account2.AccountNumber = "987654321";
account2.AccountHolderName = "Jane Smith";
account2.Currency = new Currency { amount = 500 };
Console.WriteLine("Initial Balances:");
Console.WriteLine("Account 1: {0} {1}", account1.AccountNumber, account1.BalanceCheck());
Console.WriteLine("Account 2: {0} {1}", account2.AccountNumber, account2.BalanceCheck());
Console.WriteLine();
Currency depositAmount = new Currency { amount = 250 };
Currency withdrawAmount = new Currency { amount = 200 };
account1.Deposit(depositAmount);
account2.Withdraw(withdrawAmount);
account1.TransferFunds(account2, new Currency { amount = 300 });
Console.WriteLine("Updated Balances:");
Console.WriteLine("Account 1: {0} {1}", account1.AccountNumber, account1.BalanceCheck());
Console.WriteLine("Account 2: {0} {1}", account2.AccountNumber, account2.BalanceCheck());

