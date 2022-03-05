using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            //Boxing
            list.Add(1);
            list.Add("Ali");
            list.Add(DateTime.Now);

            //Unboxing
            var number = (int)list[0];
            Console.WriteLine(number);


            //Unboxing
            var anotherList = new List<int>();
            anotherList.Add(1);
        }
    }
}
