using System;

namespace Introduction_to_Classes
{
    public class Person
    {
        public string Name { get; set; }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}
