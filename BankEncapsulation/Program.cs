using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankEncapsulation();
            Console.WriteLine("Hello! Welcome to your fictional bank account. Please enter an amount you would like to deposit.");
            var depositAmount = int.Parse(Console.ReadLine());
            userAccount.Deposit(depositAmount);
            userAccount.GetBalance();
        }
    }
}
