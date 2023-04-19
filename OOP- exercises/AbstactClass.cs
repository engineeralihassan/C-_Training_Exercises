using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__exercises
{
    public class MathUtility
    {
        public static int GetSum(int number1, int number2 )
        {
            return number1 + number2;
        }
        public static void  PrintSum( int number1 , int number2 )
        {
            Console.WriteLine(GetSum(number1 , number2));
        }

    }
    public class BankAccount
    {
        private double balance;
        private int accountNumber;

        public BankAccount()
        {
            balance = 0;
            accountNumber = AccountManager.GenerateAccountNumber( );
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }
    }

    public static class AccountManager
    {
        private static int lastAccountNumber = 1000;

        public static int GenerateAccountNumber()
        {
            return ++lastAccountNumber;
        }

        public static void DisplayAccountDetails( BankAccount account )
        {
            Console.WriteLine("Account Number: {0}" , account.AccountNumber);
            Console.WriteLine("Balance: {0:C}" , account.Balance);
        }
    }
    public class AbstactClass
    {
        private static void Main()
        {
            MathUtility.PrintSum(12 , 56);
            BankAccount account1 = new BankAccount( );
            BankAccount account2 = new BankAccount( );

            account1.Balance = 1000;
            account2.Balance = 500;

            AccountManager.DisplayAccountDetails(account1);
            AccountManager.DisplayAccountDetails(account2);

        }

    }
}
