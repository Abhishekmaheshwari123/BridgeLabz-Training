using System;

class BankAccount
{
    public static string BankName = "State Bank";
    public static int TotalAccounts = 0;

    public string AccountHolderName;
    public readonly string AccountNumber;
    public double Balance;

    public BankAccount(string accountHolderName, string accountNumber, double balance)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        this.Balance = balance;

        TotalAccounts++;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + TotalAccounts);
    }

    public void DisplayDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank: " + BankName);
            Console.WriteLine("Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    static void Main(string[] args)
    {
        BankAccount a1 = new BankAccount("Abhi", "ACC001", 5000);
        BankAccount a2 = new BankAccount("Riya", "ACC002", 7000);

        a1.DisplayDetails();
        Console.WriteLine();
        a2.DisplayDetails();

        Console.WriteLine();
        BankAccount.GetTotalAccounts();
    }
}
