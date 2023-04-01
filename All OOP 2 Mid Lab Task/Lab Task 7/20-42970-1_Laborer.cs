using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    internal class Laborer
    {
        public string id;
        public string name;
        public string address;
        public int userRating;
        public string chargePerService = "500 Taka";
        public int noOfService;
        public Laborer(string name, string id, string address, int userRating, int noOfService)
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.userRating = userRating;
            this.noOfService = noOfService;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Laborer Name: " + name);
            Console.WriteLine("Laborer ID: " + id);
            Console.WriteLine("Laborer Address: " + address);
            Console.WriteLine("Employee Status: " + this.EmployeeStatus());
        }
        public bool EmployeeStatus()
        {
            return userRating > 70 && noOfService >= 10;
        }
        public int TotalEarn()
        {
            return 8000;
        }
    }
}
