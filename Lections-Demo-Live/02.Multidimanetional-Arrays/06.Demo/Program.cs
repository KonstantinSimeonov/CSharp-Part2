using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Demo
{
    class Program
    {
        static void Main(string[] args)
        {                                                       // Arrays in Arrays - Wont use them ever !!!
            int[,][,] strangeArray = new int[3, 4][,];
            for (int i = 0; i < strangeArray.GetLength(0); i++)
            {
                for (int j = 0; j < strangeArray.GetLength(1); j++)
                {
                    strangeArray[i, j] = new int[x, y];
                }
            }
        }
    }
}
