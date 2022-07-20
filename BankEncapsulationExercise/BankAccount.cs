using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        public BankAccount(double balance)
        {
            Balance = balance;
        }
        public BankAccount(double balance, double amount)
        {
            Balance = balance;
            Amount = amount;
        }

        private double Balance { get; set; }
        private double Amount { get; set; }
        public double Deposit(double amount)
        {
            return Balance+= amount;
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
