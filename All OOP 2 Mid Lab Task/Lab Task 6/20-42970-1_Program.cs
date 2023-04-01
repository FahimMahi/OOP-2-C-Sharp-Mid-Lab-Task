using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account("Fahim Mahmud Bhuiyan", "20-42970-1", 2000);
            Console.WriteLine("Account's Owner Name: " + obj.AccName);
            Console.WriteLine("Account's Owner ID: " + obj.AccID);
            Console.WriteLine("Account's Owner Balance: " + obj.AccBalance);
            obj.Withdraw(500);
            Console.WriteLine("After Withdrawing Account's Owner Balance: " + obj.AccBalance);
            obj.Deposit(420);
            Console.WriteLine("After Depositing Account's Owner Balance: " + obj.AccBalance);
            obj.Transfer(500,1220);
            Console.WriteLine("After Transfering Account's Owner Balance: " + obj.AccBalance);
            Console.WriteLine();


            Book book = new Book("Himu", "Humayan Ahmed", "12-331", "Fictional character", 50);
            book.ShowInfo();
            book.AddBookCopy(30);
            Book.bookCounter = 4;
            Book.showTotalInfo();
            Console.WriteLine();


            Contact contact = new Contact("Fahim Mahmud Bhuiyan", "20-42970-1", 20, "01850311282", 'M');
            contact.ShowPersonInfo();
            contact.DetectMobileOperator();
            Console.WriteLine();


            Course course = new Course("OOP 2", "22-1113-2", 3);
            course.ShowCourseInfo();
            Console.WriteLine();


            Mobile mobile = new Mobile("Fahim Mahmud Bhuiyan", "01850311282", 120, "Robi", true);
            mobile.ShowInfo();
            mobile.Recharge(200);
            Console.WriteLine("After recharging total Balance is: " + mobile.MobileBalance);
            mobile.CallSomeone(5);
            Console.WriteLine("After calling someone total Balance is: " + mobile.MobileBalance);
            Console.WriteLine();

            Library library = new Library("Bornomala Library", "Mirpur", 420);
            library.ShowLibInfo();
            library.AddNewBook(20);
            Console.WriteLine("After Adding Total book is: " + library.TotalBook);
            library.DeleteBook(40);
            Console.WriteLine("After Delating Total book is: " + library.TotalBook);
            library.AddNewBookCopy(book, 50);
            Console.WriteLine("After Adding Total book is: " + library.TotalBook);
            Console.WriteLine();

            AddressBook addressBook = new AddressBook("Fahim Mahmud Bhuiyan", "Mirpur");
            addressBook.ShowAllContactInfo();
            Console.WriteLine("Total Contact: " + addressBook.TotalContact);
            addressBook.AddContact(32);
            Console.WriteLine("After Adding Total Contact is: " + addressBook.TotalContact);
            addressBook.DeleteContact(16);
            Console.WriteLine("After Delating Total Contact is: " + addressBook.TotalContact);
            Console.WriteLine();

        }
    }
}
