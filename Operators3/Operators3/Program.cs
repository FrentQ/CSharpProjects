using System;
using System.Collections.Generic;

namespace Operators3;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers.");
        float n1 = float.Parse(Console.ReadLine());
        float n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Number 1 is greater than number 2 and 5: {0}", n1>n2 && n1>5);
        Console.WriteLine("Number 2 is less than number 1 and 20: {0}", n2<n1 && n2<20);
        Console.WriteLine("Number 1 is less than number 2 and 12: {0}", n1<n2 && n1<12);
        Console.WriteLine("Number 2 is greater than nubmer 1 and 3: {0}", n2>n1 && n2>3);
        Console.WriteLine("Number 1 is equal to number 2 or 18: {0}", n1==n2 || n1 == 18);
        Console.WriteLine("Number 1 isn't equal to number 2 or 5: {0}", n1!=n2 || n1!=5);
    }
}