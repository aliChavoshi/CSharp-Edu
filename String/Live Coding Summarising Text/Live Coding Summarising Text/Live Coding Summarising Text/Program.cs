using System;
using System.Collections.Generic;

namespace Live_Coding_Summarising_Text
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going TO be a Realy Realy Realy Realy Realy Realy Realy Realy Realy Realy";
            var summary = StringUtility.Summerize(sentence, 20);
            Console.WriteLine(summary);

        }



    }
}
