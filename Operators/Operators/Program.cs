using System;
using System.Collections.Generic;

namespace Operators;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers.");
        float sayi1 = Convert.ToInt32(Console.ReadLine());
        float sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nSum: {0}", sayi1 + sayi2);
        Console.WriteLine("\nDifference: {0}", sayi1 - sayi2);
        Console.WriteLine("\nProduct: {0}", sayi1 * sayi2);
        Console.WriteLine("\nDivision: {0}", sayi1 / sayi2);
        Console.WriteLine("\nMod: {0}", sayi1 % sayi2);
    }
}