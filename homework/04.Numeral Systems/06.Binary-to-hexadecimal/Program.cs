using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static string HexadecimToBinary(string hexadecNumber)
        {
            string binary = string.Empty;
            for (int i = 0; i < hexadecNumber.Length; i++)
            {
                switch (hexadecNumber[i])
                {
                    case '0': binary += "0000"; break;
                    case '1': binary += "0001"; break;
                    case '2': binary += "0010"; break;
                    case '3': binary += "0011"; break;
                    case '4': binary += "0100"; break;
                    case '5': binary += "0101"; break;
                    case '6': binary += "0110"; break;
                    case '7': binary += "0111"; break;
                    case '8': binary += "1000"; break;
                    case '9': binary += "1001"; break;
                    case 'A': binary += "1010"; break;
                    case 'B': binary += "1011"; break;
                    case 'C': binary += "1100"; break;
                    case 'D': binary += "1101"; break;
                    case 'E': binary += "1110"; break;
                    case 'F': binary += "1111"; break;
                }
            }
            return binary.TrimStart('0');
        }
        static string BinaryToHexadecimal(string binary)
        {
            string hexadecNumber = string.Empty;

            for (int i = 0; i < binary.Length % 4; i++)
            {
                binary = "0" + binary;
            }
            for (int i = 0; i < binary.Length; i += 4)
            {
                switch (binary.Substring(i, 4))
                {
                    case "0000": hexadecNumber += "0"; break;
                    case "0001": hexadecNumber += "1"; break;
                    case "0010": hexadecNumber += "2"; break;
                    case "0011": hexadecNumber += "3"; break;
                    case "0100": hexadecNumber += "4"; break;
                    case "0101": hexadecNumber += "5"; break;
                    case "0110": hexadecNumber += "6"; break;
                    case "0111": hexadecNumber += "7"; break;
                    case "1000": hexadecNumber += "8"; break;
                    case "1001": hexadecNumber += "9"; break;
                    case "1010": hexadecNumber += "A"; break;
                    case "1011": hexadecNumber += "B"; break;
                    case "1100": hexadecNumber += "C"; break;
                    case "1101": hexadecNumber += "D"; break;
                    case "1110": hexadecNumber += "E"; break;
                    case "1111": hexadecNumber += "F"; break;
                }
            }
            return hexadecNumber;
        }
        static void Main(string[] args)
        {
            //string hexaDecNumber = Console.ReadLine();
            //Console.WriteLine(HexadecimToBinary(hexaDecNumber));
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimal(binaryNumber));
        }
    }
}
