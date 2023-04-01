using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account()
        {
            //Empty Constructor
        }

        public Account(string aName, string aID, int Balance)
        {
            this.AccName = aName;
            this.AccID = aID;
            this.AccBalance = Balance;
        }

        public string AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }

        public string AccID
        {
            get
            {
                return acid;
            }
            set
            {
                acid = value;
            }
        }

        public int AccBalance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Deposit(int amount)
        {
            AccBalance = AccBalance + amount;
        }

        public void Withdraw(int amount)
        {
            AccBalance = AccBalance - amount;
        }

        public void Transfer(int amount, int AccountReceiver)
        {
            if (amount < AccBalance)
            {
                AccBalance -= amount;
                Console.WriteLine(amount + " added the amount in account number of " + AccountReceiver);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}