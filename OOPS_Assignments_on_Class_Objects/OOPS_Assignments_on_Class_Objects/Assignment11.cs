using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Bank
    {
        private static double interestRate;

        private double balance;

        static Bank()
        {
            interestRate = 5.5;
            Console.WriteLine($"Static Constructor : Interest rate is {interestRate}%");
        }

        public Bank(double initialBalance)
        {
            balance = initialBalance;
            Console.WriteLine($"Regular Constructor : Account balance is {balance}");
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Balance : {balance}");
            Console.WriteLine($"Interest Rate : {interestRate}%");
        }

        public static void UpdateInterestRate(double newRate)
        {
            interestRate = newRate;
            Console.WriteLine($"Interest rate updated : {interestRate}%");
        }
    }
}
