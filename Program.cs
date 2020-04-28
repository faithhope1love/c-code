using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Programmer: Corin
 * Date: 11/16/18
 * Purpose: In Chapter 11, Answer Question #7, Assignment #3 for Week 3 create a base class for a banking account. Decide what characteristics
 * are common for a checking and a savings account and use them in the base class. Do not allow the banking base account to be instantiated, only the
 * subclasses check and savings.
 */
namespace bankClasses
{
    class BankAccount
    {
        string accountName;
        int accountAmount;
        double accountInterest;
        double accountTotal;

        public string getAccountName()
        {
            return accountName;
        }
        public void setAccountName(string newName)
        {
            accountName = newName;
        }
        public int getAccountAmount()
        {
            return accountAmount;
        }
        public void setAccountAmount(int newAmount)
        {
            accountAmount = newAmount;
        }
        public double getAccountInterest()
        {
            return accountInterest;
        }
        public void setAccountInterest(double newInterest)
        {
            accountInterest = newInterest;
        }

        public class CheckingAccount : BankAccount
        {
            public CheckingAccount(string name, int amount, double interest) : base()
            {
                accountName = "Checking";
                accountAmount = 800;
                accountInterest = 0.10;

                name = accountName;
                amount = accountAmount;
                interest = accountInterest;

                accountTotal = accountAmount * accountInterest;
            }
            public string checkingAccountName()
            {
                return accountName;
            }

            public int checkingAccountAmount()
            {
                return accountAmount;
            }
            public double checkingAccountTotal()
                {
                    return accountTotal;
                }
            }

        public class SavingsAccount : BankAccount
        {

            public SavingsAccount(string name, int amount, double interest) : base()
            {
                accountName = "Savings";
                accountAmount = 4500;
                accountInterest = 0.10;

                name = accountName;
                amount = accountAmount;
                interest = accountInterest;

                accountTotal = accountAmount * accountInterest;
            }

            public string savingsAccountName()
            {
                return accountName;
            }

            public int savingsAccountAmount()
            {
                return accountAmount;
            }

            public double savingsAccountTotal()
            {
                return accountTotal;
            }
        }

        static void Main()
        {
            CheckingAccount Checking = new CheckingAccount("Checking",800,0.10);
            Console.WriteLine("This is your " + Checking.checkingAccountName() + " account. " + "\nYou have $" + Checking.accountAmount + " in your account." +
                "\nThe interest rate in your checking account is $" + Checking.accountTotal);
            Console.ReadLine();

            SavingsAccount Savings = new SavingsAccount("Saving",4500,0.10);
            Console.WriteLine("This is your " + Savings.savingsAccountName() + " account. " + "\nYou have $" + Savings.accountAmount + " in your account." +
            "\nThe interest rate in your savings account is $" + Savings.accountTotal);
            Console.ReadLine();
        }
    }
}
