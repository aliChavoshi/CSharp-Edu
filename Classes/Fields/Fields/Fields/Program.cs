using System;

namespace Fields
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var custome = new Customer(1);
            //custome.orders.Add(new Order());
            //custome.orders.Add(new Order());


            //custome.Promote();

            //Console.WriteLine("Count: {0}" , custome.orders.Count);


            var person = new Person();
            person.SetBirthdate(new DateTime(2020, 5, 5).Date);
            Console.WriteLine(person.GetBirthdate());

        }
    }
}
