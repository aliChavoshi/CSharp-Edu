using System;

namespace TheBase_keyword
{
    public class Car : Vehicle
    {
        //public Car()
        //{
        //    Console.WriteLine("Car");
        //}

        public Car(string registerationNumber) : base(registerationNumber)
        {
            Console.WriteLine("Car {0}", registerationNumber);
        }
    }
}
