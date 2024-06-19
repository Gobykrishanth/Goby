using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Transaction
    {
        public int TransactionID;
        public int AccountNumber;
        public decimal Amount;
        public string TransactionType;
        public DateTime Date;

        public void GetTransactionDetails()
        {
            Console.WriteLine($"{TransactionID}\n" +
                $"{AccountNumber}\n" +
                $"{Amount}\n" +
                $"{TransactionType}\n" +
                $"{Date}");

        }

    }
}
