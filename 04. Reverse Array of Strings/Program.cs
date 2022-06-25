using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ", inputString.Reverse()));
        }
    }
}
