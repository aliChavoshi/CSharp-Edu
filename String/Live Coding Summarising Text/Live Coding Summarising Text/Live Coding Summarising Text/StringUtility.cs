using System;
using System.Collections.Generic;
using System.Text;

namespace Live_Coding_Summarising_Text
{
    public static class StringUtility
    {
        public static string Summerize(string text, int maxLenght)
        {
            if (text.Length < maxLenght)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length;
                if (totalCharacters > maxLenght)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
