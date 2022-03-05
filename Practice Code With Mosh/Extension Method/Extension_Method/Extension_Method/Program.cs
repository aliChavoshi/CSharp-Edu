using System;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringPost = "This Text in very Long and this Text Is Very Long";
            Console.WriteLine(stringPost.Shorter(3));
        }
    }
}
