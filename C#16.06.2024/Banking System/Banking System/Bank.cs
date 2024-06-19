using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Bank
    {
        public string Name;
        public List<Customer> Customers;

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void GetCustomerDetails()
        {
            Console.WriteLine(Customers);
        }

        public void TransferFunds(Account account, decimal amount)
        {
            Console.WriteLine(account, amount);
        }
    }
}
