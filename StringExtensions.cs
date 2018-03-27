using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        // To create an extension method, use 'this' in front of the first argument
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException(nameof(numberOfWords), "numberOfWords must be a positive number.");

            var wordsArray = str.Split(' ');

            if (wordsArray.Length <= numberOfWords)
            {
                return str;
            }

            return String.Join(" ", wordsArray.Take(numberOfWords)) + "...";
        }
    }
}
