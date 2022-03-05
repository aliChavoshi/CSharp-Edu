using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverride
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //Any Code Specific to the circle itself
            Console.WriteLine("Draw a Circle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("default");
        }

        //public ShapeType Type { get; set; }
    }
}
