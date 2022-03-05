using System.Security.Cryptography;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new NumbersList();
            numbers.Add(1);

            var books = new BookList();
            books.Add(new Book());

            var numbersGeneric = new GenericList<int>();
            numbersGeneric.Add(1);

            var booksGeneric = new GenericList<Book>();
            booksGeneric.Add(new Book());


            var dictionary = new DictionaryList<string, Book>();
            dictionary.Add("123", new Book());


            var calclator = new DiscountCalculator<Book>();
            System.Console.WriteLine(calclator.Calculator(new Book() { Price = 100f }));


            var nullable = new Nullable<Users>();
            System.Console.WriteLine("Has Value : " + nullable.HasValue);
            System.Console.WriteLine("Value :" + nullable.GetValueOrDefault());
        }
    }
}
