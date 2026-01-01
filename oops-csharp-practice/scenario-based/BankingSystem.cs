using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class BankSystem
    {
        static double CheckForUser()
        {
            Bank User = new Bank();
            Console.WriteLine("Enter Account No.");
            double accountNo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your PIN");
            double PIN = double.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (accountNo == User.UserData[i, 0] && PIN == User.UserData[i, 1])
                {
                    return accountNo;
                }
            }
            Console.WriteLine("You Account No. or PIN is Incorrect. Pls Retry Again");
            return CheckForUser();
        }

        static bool CheckForAccountManager()
        {
            Bank Manager = new Bank();
            Console.WriteLine("Enter Manager Id.");
            int ManagerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Password");
            int Password = int.Parse(Console.ReadLine());

            if (ManagerId == Manager.AccountManagerId && Password == Manager.AccountMangerPIN)
            {
                return true;
            }
            Console.WriteLine("You Id or Passwrod is Incorrect. Pls Retry Again");
            return CheckForAccountManager();
        }

        static void Operations(int role, double accountNo)
        {
            Console.WriteLine("----Bank Menu----");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdrawl");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            int operations = Convert.ToInt32(Console.ReadLine());
            Manager manager = new Manager();
            if (operations == 1)
            {
                Console.Write("Enter the Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                manager.Deposite(accountNo, amount);
                Operations(role ,  accountNo);
            }
            else if (operations == 2)
            {
                Console.Write("Enter the Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                manager.Withdrawl(accountNo, amount);
                Operations(role, accountNo);
            }
            else if (operations == 3)
            {
                manager.CheckBalance(accountNo);
                Operations(role, accountNo);
            }
            else if (operations == 4)
            {
                Console.WriteLine("Thanks you and visit again!");
                Console.WriteLine("If You want to visit again Enter 1");
                int again = int.Parse(Console.ReadLine());
                if (again == 1)
                {
                    Operations(role, accountNo);
                }
                else return;
            }
            else
            {
                Console.WriteLine("Please Enter a valid Operation");
                Operations(role, accountNo);
            }
        }
        static void ValidateRole()
        {

            Console.WriteLine("Enter 1. For Client OR 2. For Bank Manager");
            int role = int.Parse(Console.ReadLine());
            Bank bank = new Bank();
            if (role == 1)
            {
                // check Id Passward of user
                double accountNo = CheckForUser();
                if (accountNo != -1)
                {
                    User currentUser = new User();
                    Console.WriteLine("Welcome "+currentUser.Name+" to "+bank.BankName);
                    Operations(role,accountNo);
                }
            }
            else
            {
                // check Id Password of Bank Manager
                bool validate = CheckForAccountManager();
                if ((validate))
                {
                    ManagerOperations();
                }
            }
        }

        static void ManagerOperations()
        {
            Manager currentManager = new Manager();
            Bank bank = new Bank();
            Console.WriteLine("Welcome " + currentManager.Name + " to " + bank.BankName);
            Console.WriteLine("----Bank Manager Menu----");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Exit");

            int operation = int.Parse(Console.ReadLine());
            if (operation == 1)
            {
                
                double balance = FindBalance();
                if (balance == -1)
                {
                    Console.WriteLine("No client find with this AccountNumber");
                    Console.WriteLine("Please again Enter the AccountNumber");
                    balance = FindBalance();
                }
                else
                {
                    FindBalance();
                }
            }
        }


        static double FindBalance()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the account I'd of that client");
            double clientId = double.Parse(Console.ReadLine());
            double balance = -1;
            for (int i = 0; i < bank.UserData.GetLength(0); i++)
            {
                if (bank.UserData[i, 0] == clientId)
                {
                    balance = bank.UserData[i, 2];
                    break;
                }
            }
            if (balance == -1) return -1;
            Console.WriteLine("Balance = " + balance);
            Console.WriteLine("If you want to check the balance of another client Please Enter 1");
            int againcheck = int.Parse(Console.ReadLine());
            if (againcheck == 1) balance = FindBalance();


            return 0;
        }


        public static void Main(string[] args)
        {
            // validate function by role
            ValidateRole();
        }
    }

    public class Bank
    {
        // public fields
        public string BankName;
        public string[] BranchName;
        public string[] IFSCCode;

        // fix fields
        public readonly int MinBalance = 2000; // minimum balance 2000
        public readonly int MaxTransaction = 100000; // max transaction 1 Lakh only per day
        public readonly int MaxNoOfTransaction = 5;  // max. no. of transaction per day    

        // Acount Manager Details 
        public readonly int AccountManagerId = 1234; // Account Manager  Login Id
        public readonly int AccountMangerPIN = 4321; // Account Manager Login PIN

        // user Account Details (Account No., PIN, Current Balance)

        public double[,] UserData = new double[10, 3]
                            {
                                { 1001, 1111, 0 },
                                { 1002, 2222, 0 },
                                { 1003, 3333, 0 },
                                { 1004, 4444, 0 },
                                { 1005, 5555, 0 },
                                { 1006, 6666, 0 },
                                { 1007, 7777, 0 },
                                { 1008, 8888, 0 },
                                { 1009, 9999, 0 },
                                { 1010, 1234, 0 }
                            };


    }

    public class User
    {
        public string Name;
        public string BankName;


    }

    public class Manager
    {
        public string Name;
        static Bank bank = new Bank();

        internal void Deposite(double accountNo, double amount)
        {
            for(int i = 0; i < bank.UserData.GetLength(0); i++)
            {
                if(bank.UserData[i,0] == accountNo)
                {
                    Console.Write("Current Amount: " + bank.UserData[i, 2] + " ");
                    bank.UserData[i,2] += amount;
                    Console.WriteLine("Updated Amount: " + bank.UserData[i, 2]);
                    Console.WriteLine();
                    //break;    
                }
            }
        }

        internal void Withdrawl(double accountNo, double amount)
        {
            for (int i = 0; i < bank.UserData.GetLength(0); i++)
            {
                if (bank.UserData[i, 0] == accountNo)
                {
                    if(amount > (bank.UserData[i,2] - 2000))
                    {
                        Console.WriteLine("Insufficient Balance");
                        Console.WriteLine(); 
                        return;
                    }
                    Console.Write("Current Amount: "+bank.UserData[i, 2]);
                    bank.UserData[i, 2] -= amount;
                    Console.WriteLine("Updated Amount: "+bank.UserData[i, 2]);
                    Console.WriteLine();
                    //break;
                }
            }
        }

        internal void CheckBalance(double accountNo)
        {
            for (int i = 0; i < bank.UserData.GetLength(0); i++)
            {
                if (bank.UserData[i, 0] == accountNo)
                {
                    Console.WriteLine("Current Amount: "+bank.UserData[i, 2]);
                    return;
                }
            }
        }
    }


}