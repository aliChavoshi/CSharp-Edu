using System;

namespace Methods
{
    public class MyClass
    {
        public void MyMethod(out int result)
        {
            result = 1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //Controll bug
            try
            {
                //return int
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            //Out Result
            int number;
            //retuen bool
            var result = int.TryParse("1", out number);
            //Controll Bug
            if (result)
            {
                Console.WriteLine("Number {0} , Result {1}", number, result);
            }
            else
            {
                Console.WriteLine("Error");
            }

          
        }

        void UseParams()
        {
            var calculatort = new Calculator();
            Console.WriteLine(calculatort.Add(1, 2));
            Console.WriteLine(calculatort.Add(1, 2, 3));
            Console.WriteLine(calculatort.Add(1, 2, 3, 4));
            Console.WriteLine(calculatort.Add(new int[] { 1, 2, 4, 5, 3 }));
        }

        static void UsePoints()
        {

            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));
                point.Move(null);

                Console.WriteLine("Poin is at ({0},{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Poin is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

        }
    }
}
