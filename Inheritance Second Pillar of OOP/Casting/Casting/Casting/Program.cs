using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting 1
            //var text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);


            //Upcasting 2
            StreamReader reader = new StreamReader(new MemoryStream());

            //Upcasting 3
            var list = new ArrayList();
            list.Add(1);
            list.Add("ali");
            list.Add(new Text());


            var anotherList = new List<int>();


            //Downcasting
            Shape shape = new Text();
            Text text = (Text)shape;

        }
    }
}
