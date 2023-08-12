using System;
using System.Collections.Generic;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number that you want to calculate its factorial.");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"\n{num}! = {fact}");
        }
    }
}