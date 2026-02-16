using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinToDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nDecNum = 0;
            var nBinPower = 1;
            var nMaxBinaryLen = Math.Truncate(Math.Log(uint.MaxValue,2));
            var oRegEx = new Regex("[0-1]");
            Console.WriteLine("Input a binary number");
            var strLine = Console.ReadLine();
            var nStrLen = strLine.Length;
            var nMatches = oRegEx.Matches(strLine).Count;
            var bRightString = (nStrLen <= nMaxBinaryLen) && (nStrLen == nMatches);
            if (!bRightString)
            {
                Console.WriteLine("Wrong binary number format!!!");
                Console.Read();
                return;
            }
            for (int i = 0; i < nStrLen; i++)
            {
                int nBinDight = strLine[nStrLen - 1 - i] - '0';
                nDecNum += (nBinDight * nBinPower);
                nBinPower *= 2;
            }
            Console.WriteLine("The decenary equivalent of the binary number {0} is {1}", strLine, nDecNum);
            Console.Read();
        }
    }
}
