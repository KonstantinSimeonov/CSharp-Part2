namespace _10.Unicode_characters
{
    using System;
    using System.Text;

    class Program
    {
        //private static string ParseUnicodeFromString(string text)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (var letter in text)
        //    {
        //        result.Append(String.Format("\\u{0:X4}", (int)letter));
        //    }
        //    return result.ToString();
        //}
        static void Main()
        {
            string textToConvert = Console.ReadLine();
            
            //string[]  = new string[text]
            //Encoding unicode = Encoding.Unicode;
            byte[] stringByte = Encoding.Unicode.GetBytes(textToConvert);
            char[] stringChar = Encoding.Unicode.GetChars(stringByte);
            StringBuilder result = new StringBuilder();
            Array.ForEach<char>(stringChar, c => result.AppendFormat("\\u{0:X4}", (int)c));
            Console.WriteLine(result);
            //Console.WriteLine(ParseUnicodeFromString(textToConvert));
        }
    }
}
