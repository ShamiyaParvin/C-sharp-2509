using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Bank2
    {
        public class Account
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }

            public Account(int accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public List<Account> Accounts { get; set; }

            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }

            public void AddAccount(int accountNumber, double balance)
            {
                Accounts.Add(new Account(accountNumber, balance));
            }
        }
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
            Console.WriteLine($"Customer {name} added\n");
        }

        public void AddAccountToCustomer(string customerName, int accountNumber, double balance)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, balance);
                Console.WriteLine($"Account added to customer {customerName}\n");
            }
            else
            {
                Console.WriteLine($"Customer {customerName} not found\n");
            }
        }
        public void DisplayCustomerDetails()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Name}\n");
                foreach (var account in customer.Accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}\n");
                }
            }
        }
    }
}
