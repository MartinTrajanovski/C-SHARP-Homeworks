using SEDC_Library_App.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC_Library_App.Services
{
    public class BookService
    {
        public Book[] Books{ get; set; }

        public BookService()
        {
            Books = new Book[]
            {
                new Book()
                {
                    Author = "Bob",
                    Genre = "Novel",
                    Pages = 200,
                    Title  = "Harry"
                },
                new Book()
                {
                    Author = "Jack",
                    Genre = "Comic",
                    Pages = 400,
                    Title  = "Spiderman"
                },
                new Book()
                {
                    Author = "Jill",
                    Genre = "Adventure",
                    Pages = 6400,
                    Title  = "Star Wars"
                }
            };
        }
        public void PrintAllBooks()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("There are no books yet!");
                return;
            }
            foreach (Book book in Books)
            {
                Console.WriteLine(book.BookInfo());
            }
        }
    }
}
