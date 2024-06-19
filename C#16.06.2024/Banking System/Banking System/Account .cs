using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Account
    {
        public decimal AccountNumber;
        public decimal Balance;
        public int CustomerID;


        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance > amount)
            {
                Balance = Balance - amount;
            } else
            {
                Console.WriteLine("No Suffecient Amount for Withdrawal");
            }
            
        }

        public void Withdraw(double percentage)
        {
            Balance = Balance - (Balance*(decimal)percentage/100);
        }

        public void GetBalance()
        {
            Console.WriteLine($" Balance : {Balance}");
        }


        //Constuctor
        public Account(decimal accountNumber, decimal balance, int customerID)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            CustomerID = customerID;
        }
    }
}
