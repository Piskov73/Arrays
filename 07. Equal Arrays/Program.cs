
using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int[] secondArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            bool identical = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if(firstArray[i] != secondArray[i])
                {
                    //Arrays are not identical. Found difference at 2 index
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;
                }
            }
            if (identical)
            {
                int result=firstArray.Sum();
                Console.WriteLine($"Arrays are identical. Sum: {result}");
            }
        }
    }
}
