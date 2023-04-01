using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender; //M or F

        public Contact()
        {
            //Empty Constructor 
        }

        public Contact(string pName, string pId, int Page, string mNumber, char Pgender)
        {
            this.PersonName = pName;
            this.PersonId = pId;
            this.Age = Page;
            this.MobileNumber = mNumber;
            this.Gender = Pgender;
        }
        public string PersonName
        {
            get 
            { 
                return personName; 
            }
            set 
            { 
                personName = value; 
            } 
        }
        public string PersonId
        {
            get 
            { 
                return personId; 
            }
            set
            {
                personId = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
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
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        } 
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name: " + PersonName);
            Console.WriteLine("Person ID: " + PersonId);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Mobile Number: " + MobileNumber);
            Console.WriteLine("Gender: " + Gender);
        }

        public void DetectMobileOperator()
        {
            string mobileOperator = "Robi";
            Console.WriteLine("Mobile Operator: " + mobileOperator);
        }
    }

    internal class AddressBook
    {
        private string ownerName;
        private string info;
        private Contact[] listOfContact;

        public AddressBook()
        {
            //Empty Constructor
        }


        public AddressBook(string oName, string oinfo)
        {
            this.OwnerName = oName;
            this.Info = oinfo;
            listOfContact = new Contact[50];
        }
        public string OwnerName 
        { 
            get 
            { 
                return ownerName; 
            } 
            set 
            { 
                ownerName = value; 
            } 
        }
        public string Info 
        { 
            get 
            { 
                return info; 
            } 
            set 
            { 
                info = value; 
            } 
        }

        public void ShowAllContactInfo()
        {
            Console.WriteLine("Owner's Name: " + OwnerName);
            Console.WriteLine("Owner's Info: " + Info);
        }

        public int TotalContact = 64;
        public void AddContact(int NewContact)
        {
            TotalContact = TotalContact + NewContact;
        }
        public void DeleteContact(int DelContact)
        {
            TotalContact = TotalContact - DelContact;
        }
    }
}
