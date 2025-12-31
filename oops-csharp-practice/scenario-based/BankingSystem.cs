using System;
class BankingSystem
{
    public static void Main(String[] args)
    {
        
    }
}



public class Bank
{
    public string BankName;
    public string[] IFSCCode;
    public string[] BranchName;

    readonly int MinBalance = 2000;    
    readonly int MaxTransaction = 100000;
    readonly int MaxNumberOfTransaction = 5;                                
}