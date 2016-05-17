using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_Array
{
    class Program
    {
        static string ArraySum(byte [] firstArray, byte [] secondArray)
        {
            List<byte> max = new List<byte>();
            List<byte> min = new List<byte>();

            if (firstArray.Length > secondArray.Length)
            {
                max.AddRange(firstArray);
                min.AddRange(secondArray);
            }
            else
            {
                max.AddRange(secondArray);
                min.AddRange(firstArray);
            }

            int minLength = min.Count;
            int maxLength = max.Count;
            int sum = 0;
            int additionalNumber = 0;
            var result = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                sum = min[i] + max[i] + additionalNumber;
                if (sum >= 10)
                {
                    additionalNumber = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    additionalNumber = 0;
                }
            }
            for (int j = minLength; j < maxLength; j++)
            {
                sum = max[j] + additionalNumber;
                if (sum >= 10)
                {
                    additionalNumber = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    additionalNumber = 0;
                }
            }
            if (additionalNumber == 1)
            {
                result.Append(1);
            }
            char[] reversed = (result.ToString()).ToCharArray();
            result.Clear();
            for (int i = 0; i < reversed.Length; i++)
            {
                result.Append(reversed[i]);
                result.Append(" ");
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            byte[] firstArray = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            byte[] secondArray = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();

            Console.WriteLine(ArraySum(firstArray, secondArray));
        }
    }
}
