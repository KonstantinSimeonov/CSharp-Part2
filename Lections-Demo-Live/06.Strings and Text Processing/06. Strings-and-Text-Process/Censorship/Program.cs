using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var censorshipSymbols = "@#!?+#%!!1!!*&^!%%$!&#(!";
            var swearWords = new string[]
            {
                "bau",
                "meaw",
                "coo",
                "pur",
                "FAQ",
                "batal",
                "programist",
                "kraen result",
                "rekursia"
            };
            var forumPost = @"Dokato si vodeh lekciata reshihme da si cool 
mqu kotkata pravq 
bau ili meaw kotkata cur ili pur
 workshop po rekursia kraen result
dokato ima oshte FAQ v kursa i ima i program no nqma programist
imame vsichko koeto ni trqbva bez batal ships";

            foreach (var swear in swearWords)
            {
                forumPost = forumPost.Replace(swear, censorshipSymbols.Substring(0, swearWords.Length));

            }
            Console.WriteLine(forumPost);
        }
    }
}
