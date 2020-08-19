using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // this instantiates the Random class
            var rand = new Random();
            // this declares the list of random numbers
            // the for loop below uses the Next method to get the next number in the random list
            // the argument of '50' passed into the parantheses makes sure
            // that no number goes over 50. look at james-ramsden.com for more info on how this works
            var randList = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                randList.Add(rand.Next(50));
            }

            // console each number in the randList variable
            foreach (var num in randList)
            {
                Console.WriteLine($"{num}");
            }

            // using this as a separator so I check the math
            Console.WriteLine(new string('-', 50));

            // declare the randSquared variable as a list
            var randSquared = new List<double>();
            // loop over the randList, multipy each iteration by itself
            // saving the result to a variable that is then added to the
            // randSquared variable
            foreach (var num in randList)
            {
                var result = num * num;
                randSquared.Add(result);
            }

            // console each number in the randSquared variable
            foreach (var num in randSquared)
            {
                Console.WriteLine($"{num}");
            }

        }
    }
}
