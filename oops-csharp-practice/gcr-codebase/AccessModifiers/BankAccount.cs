using System;

class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double Balance;

    public BankAccount(string accNum, string holder, double balance)
    {
        AccountNumber = accNum;
        AccountHolder = holder;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient balance");
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string acc, string holder, double bal)
        : base(acc, holder, bal)
    {
    }

    public void ShowAccountInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);   // public ✔
        Console.WriteLine("Account Holder: " + AccountHolder);   // protected ✔
        Console.WriteLine("-----------------------");
    }

    static void Main(string[] args)
    {
        SavingsAccount sa = new SavingsAccount("ACC123", "Abhi", 5000);

        sa.ShowAccountInfo();

        sa.Deposit(2000);
        sa.Withdraw(1000);

        Console.WriteLine("Balance: " + sa.GetBalance());
    }
}
