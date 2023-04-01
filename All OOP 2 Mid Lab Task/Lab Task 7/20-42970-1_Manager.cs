using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    internal class Manager
    {
        public string id;
        public string name;
        public string address;
        public int yearOfExperience;
        public Manager(string name, string id, string address, int yearOfExperience)
        {
            this.name = name;
            this.id = id;  
            this.address = address;
            this.yearOfExperience = yearOfExperience;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Manager Name: " + name);
            Console.WriteLine("Manager ID: " + id);
            Console.WriteLine("Manager Address: " + address);
            Console.WriteLine("Employee Status:" + this.EmployeeStatus());
        }
        public bool EmployeeStatus()
        {
            return yearOfExperience > 2;
        }
    }
}
