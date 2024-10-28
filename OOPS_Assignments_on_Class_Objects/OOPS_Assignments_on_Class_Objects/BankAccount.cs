using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative");
                }
            }
        }

        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance > 0 ? initialBalance : 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited " + amount + " to account " + AccountNumber + ", New balance is " + Balance);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew " + amount + " from account " + AccountNumber + ", New balance is " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance");
            }
        }
    }
}
