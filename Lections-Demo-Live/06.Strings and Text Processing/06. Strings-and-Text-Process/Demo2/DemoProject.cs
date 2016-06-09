namespace Demo2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DemoProject
    {
        public static List<int> FindDoubleSlash(string code)
        {
            var indices = new List<int>();
            //magic
            int nextCommentStart = code.IndexOf("//");
            int nextNEwLineIndex = 0;
            while (nextCommentStart != -1)
            {
                indices.Add(nextNEwLineIndex);

                nextNEwLineIndex = code.IndexOf(Environment.NewLine, nextCommentStart);
                indices.Add(nextNEwLineIndex);

                //nextCommentStart = code.IndexOf("//", nextCommentStart - 1);
                nextCommentStart = code.IndexOf("//", nextNEwLineIndex + 1);
            }
            return indices;
        }
        static string ExtractComment(string code)
        {
            var result = new StringBuilder();

            //magic
            bool isInSingleLineComment = false;
            bool isInMultiLineComment = true;
            char last = ' ';

            foreach (var symbol in code)
            {
                if ( isInSingleLineComment || isInMultiLineComment)
                {
                    result.Append(symbol);
                }
                if (last == '/' && symbol =='/' &&  !isInMultiLineComment)
                {
                    isInSingleLineComment = true;
                }
                if (last == '/' && symbol == '*' && !isInSingleLineComment)
                {
                    isInMultiLineComment = true;
                }
                if (last == '\r' && symbol == '\n')
                {
                    isInSingleLineComment = false;
                }
                if (last == '*' && symbol == '/')
                {
                    isInMultiLineComment = false;
                }
                last = symbol;
            }
        }
        static void Main()
        {
            //var indices = FindDoubleSlash(code);

            "asdad".Substring(0, 6);

            //Console.WriteLine(string.Join(", ", indices));
            Console.WriteLine(ExtractComment);
        }

    }
}
