using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount damionRussellAccount = new BankAccount(200.05);
            Console.WriteLine(damionRussellAccount.GetBalance());
            Console.WriteLine(damionRussellAccount.Deposit(22.1));
            Console.WriteLine(damionRussellAccount.GetBalance());
            Console.ReadLine();
        }
    }
}
