namespace SanitizeText

{
    using System;

    class Startup
    {
        static void Main()
        {
            // < &#60;
            // > &#62;
            var html

            var badUsername = "<script>(hello gosho');</script>";

            var sanatized = badUsername.Replace("<", "&#60;")
                                       .Replace(">", "&#62;");
            Console.WriteLine(badUsername);
            Console.WriteLine(sanatized);
            Console.WriteLine(html, badUsername);
        }
    }
}
