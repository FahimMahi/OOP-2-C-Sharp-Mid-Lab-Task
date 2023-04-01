using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    internal class Employee
    {
        public string id;
        public string name;
        public string address;
        public Employee(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Address: " + address);
        }

    }
}
