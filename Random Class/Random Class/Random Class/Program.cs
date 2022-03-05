using System;

namespace Random_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLenght = 10;
            var buffer = new char[passwordLenght];

            for (int i = 0; i < passwordLenght; i++)

                buffer[i] = (char)('a' + random.Next(0, 30));

            var password = new String(buffer);
            Console.WriteLine(password);
        }
    }
}
