using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    class LibraryBook
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }


        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true; 
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, the book '{Title}' by {Author} is currently not available.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("Madol Duuwa", "Martin Wikramasingha");
            LibraryBook book2 = new LibraryBook("Heen saraya", "Kumarathunga Munidasa");
            LibraryBook book3 = new LibraryBook("Aba yaluwo", "T.B.Ilangarathna");

           
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

           
            Console.WriteLine("\nBorrowing Books:\n");
            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();


            Console.WriteLine("\nUpdated Library Status:\n");
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

            Console.ReadLine();
        }

        static void DisplayLibraryStatus(LibraryBook book)
        {
            Console.WriteLine($"Book Status - Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
        }
    }
}
