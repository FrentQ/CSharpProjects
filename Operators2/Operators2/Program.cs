using System;
using System.Collections.Generic;

namespace Operators2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers.");
        float n1 = float.Parse(Console.ReadLine());
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nNumber 1 is greater than or equal to number 2: {0}", n1 >= n2);
        Console.WriteLine("\nNumber 1 is less than or equal to number 2: {0}", n1 <= n2);
        Console.WriteLine("\nNumber 1 is equal to number 2: {0}", n1 == n2);
        Console.WriteLine("\nNumber 1 is not equal to number 2: {0}", n1 != n2);
    }
}