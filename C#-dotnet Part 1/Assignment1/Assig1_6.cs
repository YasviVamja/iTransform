using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum BookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }

    public struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public BookType bookType;
    }

    class Assig1_6
    {
        public static void MainExecution()
        {
            Book book = AcceptBook();

            DisplayBookDetails(book);
        }
        static Book AcceptBook()
        {
            Book book = new Book();

            Console.WriteLine("Enter the book ID: ");
            book.bookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the book title: ");
            book.title = Console.ReadLine();
            Console.WriteLine("Enter the book price: ");
            book.price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the book type (0 for Magazine, 1 for Novel, 2 for ReferenceBook, 3 for Miscellaneous): ");
            book.bookType = (BookType)Convert.ToInt32(Console.ReadLine());
            return book;
        }

        static void DisplayBookDetails(Book book)
        {
            Console.WriteLine("The book details are: ");
            Console.WriteLine("Book ID: {0}", book.bookId);
            Console.WriteLine("Book Title: {0}", book.title);
            Console.WriteLine("Book Price: {0}", book.price);
            Console.WriteLine("Book Type: {0}", book.bookType);
        }
    }
}
