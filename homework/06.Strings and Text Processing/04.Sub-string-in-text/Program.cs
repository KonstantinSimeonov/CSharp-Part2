namespace _04.Sub_string_in_text
{

    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    class Program
    {
        private static int CountSubstringCointainedInGivenText(string pattern, string textFullToSubstring)
        {
            int countInputPattern = 0;
            for (int i = 0; i < textFullToSubstring.Length - pattern.Length + 1; i++)
            {
                if (textFullToSubstring.Substring(i, pattern.Length).Equals(pattern, StringComparison.OrdinalIgnoreCase))

                    countInputPattern++;
            }
            return countInputPattern;
            
        }
        static void Main()
        {
            string patternInString = Console.ReadLine();
            string textStringFull = Console.ReadLine();
            
            Console.WriteLine(CountSubstringCointainedInGivenText(patternInString, textStringFull));
        }
    }
}