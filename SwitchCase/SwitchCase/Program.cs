using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SwitchCase;

public class Program
{
    
    enum Operations
    {
        Addition=1,
        Subtraction=2,
        Multiplication=3,
        Division=4,

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers.");
        float num1 = Convert.ToInt32(Console.ReadLine());
        float num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nType 1 for addition.\nType 2 for subtraction.\nType 3 for multiplication.\nType 4 for division.\n");
        int a = Convert.ToInt32(Console.ReadLine());

        Operations choice = (Operations)a;

        switch (choice)
        {
            case Operations.Addition:
                Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");
                break;
            case Operations.Subtraction:
                Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}");
                break;
            case Operations.Multiplication:
                Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}");
                break;
            case Operations.Division:
                Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}");
                break;
            default:
                Console.WriteLine("\aEnter a number between 1 and 4.");
                break;
        }

    }
}