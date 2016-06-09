namespace Problem_4___Relevance_Index
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static string[] symbol = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

        static void Main()
        {
            string searchWord = Console.ReadLine();

            int numberOfParagraphs = int.Parse(Console.ReadLine());

            List<string> paragraph = new List<string>();
            List<int> indexes = new List<int>();

            for (int i = 0; i < numberOfParagraphs; i++)
            {
                var currentLineWords = Console.ReadLine().Split(symbol, StringSplitOptions.RemoveEmptyEntries);
                int relevanceIndex = 0;

                for (int j = 0; j < currentLineWords.Length; j++)
                {
                    string word = currentLineWords[j];
                    if (word.ToLower() == searchWord.ToLower())
                    {
                        relevanceIndex++;
                        currentLineWords[j] = word.ToUpper();
                    }
                }

                paragraph.Add(string.Join(" ", currentLineWords));
                indexes.Add(relevanceIndex);
            }

            List<string> sortedParagraphs = new List<string>();

            while (sortedParagraphs.Count < paragraph.Count)
            {
                int maxIndex = 0;
                int maxParagraphIndex = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (maxIndex <  indexes[i])
                    {
                        maxIndex = indexes[i];
                        maxParagraphIndex = i;
                    }
                }
                sortedParagraphs.Add(paragraph[maxParagraphIndex]);
                indexes[maxParagraphIndex] = -1;
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedParagraphs));
        }
    }
}

