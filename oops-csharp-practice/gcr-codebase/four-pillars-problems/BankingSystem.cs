using System;
using System.Collections.Generic;

abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    private double balance;

    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public BankAccount(int acc, string name, double bal)
    {
        AccountNumber = acc;
        HolderName = name;
        Balance = bal;
    }

    public void Deposit(double amount)
    {
        Balance = Balance + amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance = Balance - amount;
        }
    }

    public abstract double CalculateInterest();
}

interface ILoanable
{
    bool ApplyForLoan(double amount);
    bool CalculateLoanEligibility();
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int acc, string n, double b) : base(acc, n, b) { }

    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }

    public bool ApplyForLoan(double amount)
    {
        return amount <= Balance * 2;
    }

    public bool CalculateLoanEligibility()
    {
        return Balance >= 5000;
    }
}

class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(int acc, string n, double b) : base(acc, n, b) { }

    public override double CalculateInterest()
    {
        return Balance * 0.01;
    }

    public bool ApplyForLoan(double amount)
    {
        return amount <= Balance * 3;
    }

    public bool CalculateLoanEligibility()
    {
        return Balance >= 10000;
    }
}

class Program4
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(new SavingsAccount(1, "A", 10000));
        accounts.Add(new CurrentAccount(2, "B", 20000));

        foreach (BankAccount acc in accounts)
        {
            Console.WriteLine("Interest: " + acc.CalculateInterest());
        }
    }
}
