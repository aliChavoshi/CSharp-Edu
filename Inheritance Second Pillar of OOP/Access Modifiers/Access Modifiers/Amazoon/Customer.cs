using System;

namespace Amazoon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate();
            Console.WriteLine("Promote logic changed.");
        }
    }
}
