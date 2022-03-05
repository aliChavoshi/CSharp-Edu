using System;
using System.Collections.Generic;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //Upcasting
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Shape { Height = 100, Width = 200 });

            var canvas = new Canvas();
            canvas.DrawShaped(shapes);
        }
    }
}
