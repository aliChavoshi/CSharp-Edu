using System;
using System.Collections.Generic;

namespace Get_Min_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { -1, 1, 2, 3, -4, 5, 6 };
            var minNumbers = GetSmallestNumbers(numbers, 3);
            foreach (var number in minNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static List<int> GetSmallestNumbers(List<int> numbers, int count)
        {
            if (numbers.Count <= count)
            {
                return numbers;
            }

            var minNumbers = new List<int>();
            while (minNumbers.Count < count)
            {
                var min = SmallestNumber(numbers);
                minNumbers.Add(min);
                numbers.Remove(min);
            }
            return minNumbers;
        }

        public static int SmallestNumber(List<int> numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
