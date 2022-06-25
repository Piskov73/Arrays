using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] inputNumbes=Console.ReadLine().
                Split(' ',StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            foreach (var numb in inputNumbes)
            {
                if (numb % 2 == 0)
                {
                    sumEven += numb;
                }
                else if(numb % 2 != 0)
                {
                    sumOdd += numb;
                }
            }
            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
