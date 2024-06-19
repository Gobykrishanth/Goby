using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Customer
    {
        public int CustomerID;
        public string Name;
        public string Email;
        public List<Account> Accounts;

     public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
     public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }
     public void GetAccountDetails()
        {
            for( int i =0; i < Accounts.Count; i++)
            {
                Console.WriteLine($"Acc Number : {Accounts[i].AccountNumber} \n" +
                    $"Balance : {Accounts[i].Balance}");
            }
            
        }

        public Customer(int customerID, string name, string email, List<Account> accounts)
        {
            CustomerID = customerID;
            Name = name;
            Email = email;
            Accounts = accounts;
        }
    }
}
