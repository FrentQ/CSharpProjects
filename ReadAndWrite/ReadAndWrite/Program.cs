using System;
using System.Collections.Generic;

namespace ReadAndWrite;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();

        Console.WriteLine("\nEnter your age: ");
        var age = Console.ReadLine();

        Console.WriteLine("\nEnter your occupation: ");
        var ocp = Console.ReadLine();

        Console.WriteLine("\nThis user's; \nName is: " + name + "\nAge is: " + age + "\nOccupation is: " + ocp);
    }
}