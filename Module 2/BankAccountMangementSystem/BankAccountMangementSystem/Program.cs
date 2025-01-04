//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using BankAccountMangementSystem;

class Program
{
    static void Main(string[] args)
    {
        // User selects account type
        Console.WriteLine("Welcome to the Bank! What type of account would you like to open?");
        Console.WriteLine("Enter 'savings' or 'checking':");
        string accountType = Console.ReadLine().ToLower();

        Console.WriteLine("Enter the account holder's name:");
        string accountHolderName = Console.ReadLine();

        Console.WriteLine("Enter the initial balance:");
        double initialBalance = Convert.ToDouble(Console.ReadLine());

        // Use the factory to create the appropriate account
        BankAccount account = AccountFactory.CreateAccount(accountType, 123,
            343, accountHolderName, initialBalance);

        // Set interest strategy based on account type
        if (account is SavingAccount)
        {
            account.setInterestStrategy(new StandardInterest());
        }
        else if (account is CheckingAccount)
        {
            account.setInterestStrategy(new NoInterest());
        }

        // Deposit and withdraw operations
        Console.WriteLine("Enter amount to deposit:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        account.Deposit(depositAmount);

        Console.WriteLine("Enter amount to withdraw:");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        account.Withdraw(withdrawAmount);

        // Calculate interest based on strategy
        Console.WriteLine("Calculating interest...");
        account.CalculateInterest();

        // Show final balance
        Console.WriteLine($"Final balance for {account.AccountHolderName}: {account.Balance}");
    }
}
