namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con't Compile
            //var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
