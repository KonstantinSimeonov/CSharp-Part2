using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_area_in_matrix
{
    class LargestObjects
    {
        private static bool[,] visited;
        private static short[,] matrix;
        private static short maxCount = 0;
        private static short currentCount = 0;
        private static short rows;                              
        private static short cols;                              

        static void Main()
        {
            string[] sizes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            rows = short.Parse(sizes[0]);
            cols = short.Parse(sizes[1]);
            
            matrix = new short[rows, cols];
            
            for (short row = 0; row < rows; row++)    
            {
                string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (short col = 0; col < cols; col++) 
                {
                    matrix[row, col] = short.Parse(inputRows[col]);
                }
            }
            
            visited = new bool[rows, cols];

            for (short row = 0; row < rows; row++)
            {
                for (short col = 0; col < cols; col++)
                {
                    Area(row, col, matrix[row, col]);

                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 0;
                }
            }

            // Output
            Console.WriteLine(maxCount);
        }

        private static void Area(short row, short col, short currentElement)
        {
            if ((row < 0) || (row >= rows)
                || (col < 0) || (col >= cols)
                || currentElement != matrix[row, col])
            {
                return;
            }
            
            if (visited[row, col])
            {
                return;
            }
            
            visited[row, col] = true;

            currentCount++;

            Area((short)(row - 1), col, currentElement);
            Area((short)(row + 1), col, currentElement);
            Area(row, (short)(col - 1), currentElement);
            Area(row, (short)(col + 1), currentElement);     
        }

    }
}