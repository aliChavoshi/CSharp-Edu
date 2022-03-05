using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);

            numbers.AddRange(new int[3] { 5, 6, 7 });



            Console.WriteLine("index of :" + numbers.IndexOf(1));//0
            Console.WriteLine("last index of" + numbers.LastIndexOf(1));//4

            Console.WriteLine("Count :" + numbers.Count);

            numbers.Remove(1);//remove item 

            //Error Beacause Numbers Modified
            foreach (var number in numbers)
            {
                if (number == 1)
                {
                    numbers.Remove(number);
                }
            }
            //Best way for delete item from list
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            numbers.Clear();
            Console.WriteLine("Clear Count: " + numbers.Count);
        }
    }
}
