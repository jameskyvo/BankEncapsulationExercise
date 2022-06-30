using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankEncapsulation
    {
        private double balance = 0;
        public double Deposit(double depositAmount)
        {
            balance += depositAmount;
            return balance;
        }
        public double GetBalance()
        {
            Console.WriteLine($"${balance}");
            return balance;
        }
    }
}
