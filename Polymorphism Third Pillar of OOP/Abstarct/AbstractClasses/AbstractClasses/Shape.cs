namespace AbstractClasses
{
    public abstract class Shape
    {
        public abstract int Width { get; set; }


        public virtual int Height { get; set; }
        public abstract void Draw();

        public virtual void Copy()
        {
            System.Console.WriteLine("Coped.");
        }

        public abstract void Select();
    }
}
