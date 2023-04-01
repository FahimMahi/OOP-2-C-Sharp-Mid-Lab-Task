using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceProvider();
            serviceProvider.ProvideDetails();
            Console.WriteLine();
            serviceProvider.SkilledWorker();
            Console.WriteLine();
        }
    }
}
