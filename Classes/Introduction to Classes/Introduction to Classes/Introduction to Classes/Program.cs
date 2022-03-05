using System;

namespace Introduction_to_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            //var person = Person.Parse("Ali");
            //person.Introduce("Mosh");

            var customer = new Customer(1, "Jonh");
            var order = new Order();
            customer.orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
