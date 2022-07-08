using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            AdditiveCumSum additiveCumSum = new AdditiveCumSum(userInput);
            additiveCumSum.AdditiveSum();

        }
    }
}