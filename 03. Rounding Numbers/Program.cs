
using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input= Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).
                ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                //0.9 => 1
                double output = (int)Math.Round(input[i],MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {output}");
            }
        }
    }
}
