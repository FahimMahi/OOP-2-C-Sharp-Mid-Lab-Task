using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        public Book()
        {
            //Empty Constructor
        }
        public Book(string bName, string bAuthor, string bId, string bType, int bCopy)
        {
            this.BookName = bName;
            this.BookAuthor = bId;
            this.BookId = bId;
            this.BookType = bType;
            this.BookCopy = bCopy;
        }

        public string BookName
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }

        public string BookAuthor
        {
            get
            {
                return bookAuthor;
            }
            set
            {
                bookAuthor = value;
            }
        }
        public string BookId
        {
            get
            {
                return bookId;
            }
            set
            {
                bookId = value;
            }
        }

        public string BookType
        {
            get
            {
                return bookType; 
            }
            set
            {
                bookType = value;
            }
        }

        public int BookCopy
        {
            get
            {
                return bookCopy;
            }
            set
            {
                bookCopy = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Book Author: " + BookAuthor);
            Console.WriteLine("Book ID: " + BookId);
            Console.WriteLine("Book Type: " + BookType);
            Console.WriteLine("Book Copy: " + BookCopy);
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
    internal class Library
    {
        private string libName;
        private string libAddress;
        private Book [] listOfBook;
        private int totalBook;

        public Library()
        {
            //Empty Constructor
        }

        public Library(string lName, string lAddress, int tBook)
        {
            this.LibName = lName;
            this.LibAddress = lAddress;
            this.TotalBook = tBook;
            listOfBook = new Book[50];
        }
        public string LibName
        {
            get
            {
                return libName;
            }
            set
            {
                libName = value;
            }
        }
        public string LibAddress
        {
            get
            {
                return libAddress;
            }
            set
            {
                libAddress = value;
            }
        }
        public int TotalBook
        {
            get
            {
                return totalBook;
            }
            set
            {
                totalBook = value;
            }
        }
        public void ShowLibInfo()   // show library info and all book info as well
        {
            Console.WriteLine("Library Name: " + LibName);
            Console.WriteLine("Library Address: " + LibAddress);
            Console.WriteLine("Total Book: " + TotalBook);
        }

        public void AddNewBook(int nbook) // add a new book into lib 
        {
            TotalBook = TotalBook + nbook;
        }

        public void DeleteBook(int DBook) // delete book
        {
            TotalBook = TotalBook - DBook;
        }

        public void AddNewBookCopy(Book book,int copy)
        {
            TotalBook = TotalBook + copy;
        }

    }
}