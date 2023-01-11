using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        
        private double _balance = 0;

        public void Deposit (double depositAmount)
        {
            _balance += depositAmount;

            Console.WriteLine($" Deposit of ${depositAmount} was successful");
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
