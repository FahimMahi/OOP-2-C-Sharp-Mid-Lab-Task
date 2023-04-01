using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_Lab_task_2
{
    class Mammals
    {

        public void m()
        {
            Console.WriteLine("I am mammal");
        }
    }

    class MarineAnimals : Mammals
    {

        public void animal()
        {
            Console.WriteLine("I am a marine animal");
        }
    }

    class BlueWhale : MarineAnimals
    {
        public void categories()
        {
            Console.WriteLine("I belong to both categories: Mammals as well as Marine Animals");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BlueWhale obj = new BlueWhale();
            obj.m();
            obj.animal();
            obj.categories();
        }
    }
}
