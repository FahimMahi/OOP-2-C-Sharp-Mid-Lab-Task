using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber; // SIM number 
        private int mobileBalance;
        private string mobileOSName;
        private bool Lock; // true means phone is lock false means unlock

        public Mobile()
        {
            //Empty Constructor
        }

        public Mobile(string MOName, string mNumber, int mBalance, string mOSName, bool lockCheck)
        {
            this.MobileOwnerName = MOName;
            this.MobileNumber = mNumber;
            this.MobileBalance = mBalance;
            this.MobileOSName = mOSName;
            this.LockCheck = lockCheck;
        }
        public string MobileOwnerName 
        { 
            get
            {
                return mobileOwnerName;
            }
            set 
            {
                mobileOwnerName = value;
            }
        }

        public string MobileNumber
        {
            get
            {
                return mobileNumber;
            }
            set
            {
                mobileNumber = value;
            }
        }
        public int MobileBalance
        {
            get
            {
                return mobileBalance;
            }
            set
            {
                mobileBalance = value;
            }
        }
        public string MobileOSName
        {
            get
            {
                return mobileOSName;
            }
            set
            {
                mobileOSName = value;
            }
        }
        public bool LockCheck
        {
            get
            {
                return Lock;
            }
            set
            {
                Lock = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Mobile Owner Name: " + MobileOwnerName);
            Console.WriteLine("Mobile Number: " + MobileNumber);
            Console.WriteLine("Mobile Balance: " + MobileBalance);
            Console.WriteLine("Mobile OS Name: " + MobileOSName);
            Console.WriteLine("Mobile Lock is: " + LockCheck);
            Console.WriteLine("true means phone is lock false means unlock");
        }

        public void Recharge(int amount)
        {
            MobileBalance = MobileBalance + amount;
        }
        public void CallSomeone(int timeDuration)
        { // per minute cost=1 taka
            int cost = timeDuration*1;
            MobileBalance = MobileBalance - cost;
        } 

    }
}
