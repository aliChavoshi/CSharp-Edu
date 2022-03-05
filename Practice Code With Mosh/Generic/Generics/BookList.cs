using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            //Add Book
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
