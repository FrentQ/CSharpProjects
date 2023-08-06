using System;
using System.Collections.Generic;

namespace OddOrEven;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number.");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num%2 == 0 )
        {
            Console.WriteLine($"{num} is an even number.");
        }
        else
        {
            Console.WriteLine($"{num} is an odd number.");
        }
    }
}