using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Price = 100 , Title = "Aps.Net Core"},
                new Book(){Price = 20 , Title = "Jquery"},
                new Book(){Price = 50 , Title = "C#"},
                new Book(){Price = 10 , Title = "Angular"},
                new Book(){Price = 5 , Title = "CQRS"},
                new Book(){Price = 30 , Title = "MVC"}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.Where(book => GetBook(book));

            #region Linq Query Operators

            //Linq Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 20
                               orderby b.Title
                               select b.Title;
            #endregion

            #region Linq Extension Methods

            //Linq Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 20)
                .OrderBy(x => x.Title)
                .Select(x => x.Title);

            #region SingleOrDefault

            var book = books.SingleOrDefault(b => b.Title == "Angular");

            #endregion

            #region First

            var firstBook = books.FirstOrDefault(x => x.Title == "C#");
            var firstBook1 = books.FirstOrDefault(GetBook);

            #endregion

            #region Last

            var lastBook = books.LastOrDefault(x => x.Title == "Angular");


            #endregion

            #region SkipTake

            //For Pagination
            var takeSkip = books.Skip(2).Take(2);

            #endregion

            #region Count

            var count = books.Count();

            #endregion

            #region Max

            var max = books.Max(b => b.Price);
            var min = books.Min(b => b.Price);
            var sum = books.Sum(x => x.Price);
            var avr = books.Average(x => x.Price);


            #endregion
            #endregion

            #region Simple

            //var chaepBooks = new List<Book>();
            /*foreach (var book in books)
            {
                if (book.Price < 20)
                {
                    chaepBooks.Add(book);
                }
            }*/

            #endregion

            foreach (var chaepBook in cheapBooks)
            {
                Console.WriteLine(chaepBook);
            }
        }
        public static bool GetBook(Book book)
        {
            return book.Price < 20;
        }
    }
}
