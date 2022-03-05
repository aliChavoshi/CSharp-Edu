using System;

namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {
            //Not Complie
            //var test = new Person().Birthdate=DateTime.Now;

            var person = new Person(new DateTime(1991, 08, 27));
            Console.WriteLine("{0}" ,person.Age);


            //var cookie = new HttpCookie();
            //cookie["name"] = "Ali";

            //Console.WriteLine(cookie["name"]);
        }
    }   
}
