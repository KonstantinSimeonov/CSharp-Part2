namespace Problem_4_CATastrophe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        // 1. Read Input
        // 2. 
        static string[] Loops = { "for", "while", "foreach" };
        static string[] Conditionals = { "if", "else if" };
        static string[] Primitives = { "int", "bool" , "string", "short"};

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //var linesOfCode = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToArray();

            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }
            //bool isInMethod = false;
            //bool isInLoop = false;
            //bool isInCondition = false;

            var scope = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    scope.Push("method");                
                }
                else if (lines[i].Trim() == "}")
                {
                    if (scope.Count > 0)
                    {
                    scope.Pop();                       
                    }                                       
                }

                else if (lines[i].Contains(""))
                {
                    var splitByRoundBracket = lines[i].Split('(');
                    if (splitByRoundBracket.Length != 1)
                    {
                        var keyword = splitByRoundBracket[0].Trim();
                        if (Loops.Contains(keyword))
                        {
                            scope.Push("loop");
                        }
                        else if(Conditionals.Contains(keyword))
                        {
                            scope.Push("conditional");
                        }

                        //search for variables in for and foreach
                        var declaration = splitByRoundBracket[1].Split(';')[0]
                            .Split(new[]' ', StringSplitOptions.);

                        if (Primitives.Contains(declaration[0]))
                        {
                            Console.WriteLine(declaration[1]+ " " + scope.Peek());
                        }
                    }
                }
                else if (lines[i].Trim() == " else")
                {
                    scope.Push("conditional");
                }


                Console.WriteLine(i + " in scope of" + (scope.Count > 0 ? scope.Peek(): "outside"));

            }
        }
    }
}
