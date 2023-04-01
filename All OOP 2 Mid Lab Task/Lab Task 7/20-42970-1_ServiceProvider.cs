using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    internal class ServiceProvider
    {
        public void ProvideDetails()
        {
            Employee employee = new Employee("Fahim", "20-42970-1", "Mirpur");
            employee.ShowInfo();
            Console.WriteLine();
            Manager manager = new Manager("Fahim", "20-42970-1", "Mirpur", 20);
            manager.ShowInfo();
            Console.WriteLine();
            Laborer laborer = new Laborer("Fahim", "20-42970-1", "Mirpur", 100, 5);
            laborer.ShowInfo();
        }
        public void SkilledWorker()
        {
            Laborer laborer = new Laborer("Fahim", "20-42970-1", "Mirpur", 100, 30);
            if (laborer.userRating > 80)
            {
                laborer.ShowInfo();
            }
        }
    }
}
