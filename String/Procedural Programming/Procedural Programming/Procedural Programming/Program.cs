using System;

namespace Procedural_Programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name ? ");
            var name = Console.ReadLine();

            var reversed = ReverseName(name);


            Console.WriteLine("Reverse Name : " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            var reversed = "";
            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];

                reversed = new string(array);

            }
            return reversed;
        }
    }
}
