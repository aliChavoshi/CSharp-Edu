using System;

namespace StringLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ali Chavoshi ";

            Console.WriteLine("Trim : '{0}' , '{1}' ", fullName.Trim().ToLower(), fullName.ToUpper());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());


            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName : " + firstName);
            Console.WriteLine("lastName : " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName :" + names[0]);
            Console.WriteLine("lastName :" + names[1]);


            Console.WriteLine(fullName.Replace("Ali", "Ali Agha"));


            //old
            if (string.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }
            //new
            if (string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
