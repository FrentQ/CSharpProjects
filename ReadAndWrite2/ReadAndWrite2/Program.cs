using System;
using System.Collections.Generic;

namespace ReadAndWrite2;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text.");
        var text = Console.ReadLine();

        Console.WriteLine(text);
        Console.WriteLine(text.Length);
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.GetHashCode());
        Console.WriteLine(text.TrimStart());
        Console.WriteLine(text.TrimEnd());
        Console.WriteLine(text.Trim(text[0]));
        Console.WriteLine(text[2]);
        Console.WriteLine(text[text.Length-2]);

    }
}