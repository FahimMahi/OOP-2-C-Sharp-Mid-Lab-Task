using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Shape{
        public void sha()
        {
            Console.WriteLine("This is a shape");
        }
    }
    class Polygon : Shape
    {
        public void pol()
        {
            Console.WriteLine("Polygon is a shape");
        }
    }
    class Rectangle : Polygon
    {
        public void Rec(){
            Console.WriteLine("Rectangle is a polygon");
        }
    }
    class Triangle : Polygon
    {
        public void tri(){
            Console.WriteLine("Triangle is a polygon");
        }
    }
    class Square : Rectangle
    {
        public void squ(){
            Console.WriteLine("Square is a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.sha();
            obj.pol();
            obj.Rec();
            Triangle obj1 = new Triangle();
            obj1.tri();
            Square obj2 = new Square();
            obj2.squ();
        }
    }
}
