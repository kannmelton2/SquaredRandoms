using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var randList = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                randList.Add(rand.Next(50));
            }

            foreach (var num in randList)
            {
                Console.WriteLine($"{num}");
            }

        }
    }
}
