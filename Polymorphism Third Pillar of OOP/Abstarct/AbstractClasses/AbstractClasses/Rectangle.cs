using System;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }
    }
}
