using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numb=int.Parse(Console.ReadLine());
            int[] numbers=new int[numb];
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            Console.WriteLine(String.Join(" ",numbers.Reverse().ToArray()));
        }
    }
}
