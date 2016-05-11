using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] firstArray = new int[size];
            int[] secondArray = new int[size];

            bool isEqual = false;

            for (int i = 0; i < size * 2; i++)
            {
                if (i < size)
                {
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    secondArray[i - size] = int.Parse(Console.ReadLine());
                    if (secondArray[i -size] == firstArray[i - size])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual == true)
            {

                Console.WriteLine("Equal");
            }
            else
            { 
                Console.WriteLine("Not equal");
            }
            
        }
    }
}
