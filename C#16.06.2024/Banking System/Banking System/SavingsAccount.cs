using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount(decimal accountNumber, decimal balance, int customerID) : base(accountNumber, balance, customerID)
        {
        }
    }
}
