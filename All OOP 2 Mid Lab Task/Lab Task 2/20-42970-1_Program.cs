using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 100)
            {
                switch (x / 5)
                {
                    case 20:
                        Console.WriteLine("A+");
                        break;
                    case 19:
                        Console.WriteLine("A+");
                        break;
                    case 18:
                        Console.WriteLine("A+");
                        break;
                    case 17:
                        Console.WriteLine("A");
                        break;
                    case 16:
                        Console.WriteLine("B+");
                        break;
                    case 15:
                        Console.WriteLine("B");
                        break;
                    case 14:
                        Console.WriteLine("C+");
                        break;
                    case 13:
                        Console.WriteLine("C");
                        break;
                    case 12:
                        Console.WriteLine("D+");
                        break;
                    case 11:
                        Console.WriteLine("D");
                        break;
                    case 10:
                        Console.WriteLine("D");
                        break;
                    default:
                        Console.WriteLine("F");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

    }
}