//You are given a text. Write a program that changes the text in all regions 
//surrounded by the tags <upcase> and </upcase> to upper-case.

namespace _05.Parse_tags
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        private static string RenderMarkUpSting(string text)
        {
            return Regex.Replace(text, "<upcase>(.*?)</upcase>", delegate(Match match)
            {
                string current = match.ToString().ToUpper();
                return Regex.Replace(current, "<[^>]*>", String.Empty);
            });
        }
        static void Main()
        {
            string lowerCaseString = Console.ReadLine();

            var markUp = lowerCaseString;
            Console.WriteLine(RenderMarkUpSting(lowerCaseString));

        }
    }
}
