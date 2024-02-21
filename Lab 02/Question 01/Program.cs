using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    public class Book
    {
        public string Title;
        public string Author;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            
            book.Title = "Gindarii";
            book.Author = "Sunil_perera";
            
            Console.WriteLine(book.Title);  
            Console.WriteLine(book.Author);
            Console.ReadLine();
        }
    }
}
