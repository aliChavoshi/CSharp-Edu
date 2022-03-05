using System;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2015, 1, 1);

            var now = DateTime.Now;

            var today = DateTime.Today;
            Console.WriteLine("Today :" + today.Date);
            Console.WriteLine("Now :" + now);

            Console.WriteLine("Hour :" + now.Hour);
            Console.WriteLine("Minute" + now.Minute);

            var tomarrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


            TimeSpan1.Main1();
        }
    }
}
