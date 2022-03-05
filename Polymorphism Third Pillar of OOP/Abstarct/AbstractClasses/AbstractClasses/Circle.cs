using System;

namespace AbstractClasses
{
    public class Test : Circle
    {
        public override void Copy()
        {
            base.Copy();
        }

    }

    public class Circle : Shape
    {
        public override int Width { get; set; }

        public override int Height { get => base.Height; set => base.Height = value; }

        public override void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }

        public sealed override void Copy()
        {
            base.Copy();
        }

    }
}
