using System;
using System.Collections.Generic;

namespace ArithmeticCounting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to be counted arithmetic.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            for (int i = a; i <= 100; i = i + a)
            {
                Console.WriteLine("\n{0}", i);
            }
        }
    }
}