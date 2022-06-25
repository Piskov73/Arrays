using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int dey=int.Parse(Console.ReadLine());

            string[] deys = { "Monday", 
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            if (dey >= 1 && dey < 8)
            {
                Console.WriteLine(deys[dey-1]);
            }
            else
            {
                //"Invalid Day!". 
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
