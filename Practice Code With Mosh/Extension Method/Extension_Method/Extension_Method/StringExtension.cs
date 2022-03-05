using System;
using System.Linq;

namespace System
{
    public static class StringExtension
    {
        public static string Shorter(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new InvalidOperationException("چرا عدد زیر صفر دادی");

            string[] words = str.Split(" ");

            if (numberOfWords > words.Length)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}