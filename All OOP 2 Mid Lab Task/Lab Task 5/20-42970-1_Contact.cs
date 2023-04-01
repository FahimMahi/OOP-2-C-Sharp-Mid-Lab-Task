using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask5
{
    internal class Contact
    {
        public string personName;
        public string personId;
        public int age;
        public string mobileNumber;
        public char gender; //M or F

        public Contact()
        {
            //Empty Constructor 
        }

        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name: " + personName);
            Console.WriteLine("Person ID: " + personId);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Mobile Number: " + mobileNumber);
            Console.WriteLine("Gender: " + gender);
        }

        public void DetectMobileOperator()
        {
            string mobileOperator = "Robi";
            Console.WriteLine("Mobile Operator: "+ mobileOperator);
        }
    }
}
