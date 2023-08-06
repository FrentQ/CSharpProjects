using System;
using System.Collections.Generic;

namespace AbsoluteValue;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number.");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"{num} is a positive number.");
        }
        else
        {
            Console.WriteLine($"{num} is a negative number and its absolute value is {num*-1}");
        }
    }
}