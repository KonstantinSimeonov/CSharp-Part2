namespace Demo02
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static List<int> FindOfOcurrancies(string text, string word)
        {
            var indeces = new List<int>();

            int indexOfNextBacon = text.IndexOf(word);

            while (indexOfNextBacon != -1)
            {
                indeces.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf("bacon", indexOfNextBacon + 1);
            }
            return indeces;
        }
        static void Main(string[] args)
        {
            var text = @"kjasdkl1 12 bacon ipsum 1l23kj1 asd ad a a a a   123 zz  asd  bacon hh129 a7sd77a  asd7a
                         asda  dasd Bacon asdddasd bacon";
            //Console.WriteLine(text.IndexOf("bacon"));
            //Console.WriteLine(text.IndexOf("bacon"));
            var text2 = " asdaa asda bacon asdad zzz aa baaaa a  a  aacon asdada zzzz  dada aa";

            var indices = FindOfOcurrancies(text, "a");
            Console.WriteLine(string.Join(", ", indices));
            Console.WriteLine(text2.LastIndexOf("aa"));
        }
    }
}
