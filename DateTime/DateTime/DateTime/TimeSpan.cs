using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DateTime1
{
    public class TimeSpan1
    {
        public static void Main1()
        {
            //Creating
            var time = new TimeSpan(1, 2, 3);
            var time3 = TimeSpan.FromDays(1);

            var test = TimeSpan.FromDays(1);
            Console.WriteLine("Zero :" + test);

            Console.WriteLine("From Days :" + time3);

            //Diff
            var strat = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var diff = end - strat;
            Console.WriteLine("Diff :" + diff);

            //Properties

            Console.WriteLine("Minutes : " + time.Minutes);
            Console.WriteLine("Total Minutes : " + time.TotalMinutes);


            //Add
            Console.WriteLine("Add : " + time.Add(TimeSpan.FromMinutes(8)));//1:10:03
            Console.WriteLine("Subtract Add : " + time.Subtract(TimeSpan.FromMinutes(8)));//1:00:03

            //ToString
            Console.WriteLine("To String : " + time.ToString());

            TimeSpan parse = TimeSpan.Parse("01:02:03");
            Console.WriteLine(parse);
        }
    }
}
