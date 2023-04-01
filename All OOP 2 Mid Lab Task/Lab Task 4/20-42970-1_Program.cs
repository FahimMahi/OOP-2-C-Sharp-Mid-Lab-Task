using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account("Fahim Mahmud Bhuiyan", "20-42970-1", 1000);
            Console.WriteLine("Account's Owner Name: " + obj.AccName);
            Console.WriteLine("Account's Owner ID: " + obj.AccID);
            Console.WriteLine("Account's Owner Balance: " + obj.AccBalance);
            obj.Withdraw(500);
            Console.WriteLine("After Withdrawing Account's Owner Balance: " + obj.AccBalance);
            obj.Deposit(420);
            Console.WriteLine("After Depositing Account's Owner Balance: " + obj.AccBalance);
        }
    }
}
