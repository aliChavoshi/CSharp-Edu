using System;

namespace TheBase_keyword
{
    public class Vehicle
    {
        private readonly string _registerionNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle");
        //}

        public Vehicle(string registerionNumber)
        {
            _registerionNumber = registerionNumber;
            Console.WriteLine("Vehicvle {0}", registerionNumber);
        }
    }
}
