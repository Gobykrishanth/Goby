using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class CheckingAccount : Account
    {       public CheckingAccount(decimal accountNumber, decimal balance, int customerID) : base(accountNumber, balance, customerID)
        {
        }
    }

}
