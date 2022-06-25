using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int sumEwenNumbers = 0;
            foreach (int numb in inputNumber)
            {
                if (numb % 2 == 0)
                {
                    sumEwenNumbers += numb;
                }
            }
            Console.WriteLine(sumEwenNumbers);
        }
    }
}
