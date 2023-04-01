using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Himu","Humayan Ahmed","12-331", "Fictional character", 50);
            book.ShowInfo();
            book.AddBookCopy(30);
            Book.bookCounter=4;
            Book.showTotalInfo();

            Console.WriteLine();

            Contact contact = new Contact("Fahim Mahmud Bhuiyan","20-42970-1",20,"01850311282",'M');
            contact.ShowPersonInfo();
            contact.DetectMobileOperator();
        }
    }
}
