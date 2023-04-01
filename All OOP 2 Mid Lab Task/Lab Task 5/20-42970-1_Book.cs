using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask5
{
    internal class Book
    {
        public string bookName;
        public string bookAuthor;
        public string bookId;
        public string bookType;
        public int bookCopy;
        public Book()
        {
            //Empty Constructor
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Book Author: " + bookAuthor);
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Book Type: " + bookType);
            Console.WriteLine("Book Copy: " + bookCopy);
        }

        public int TotalbookCopy;
        public void AddBookCopy(int x)
        {
            TotalbookCopy = bookCopy + x;
            Console.WriteLine("Total Book Copy: " + TotalbookCopy);
        }

        public static int bookCounter;
        public static void showTotalInfo()
        {
            Console.WriteLine("Book Counter: " + bookCounter);
        }
    }
}