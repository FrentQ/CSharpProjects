using System;
using System.Collections.Generic;

namespace ifelse;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter something.");
        var a = (char)Console.Read();

        if (char.IsDigit(a))
        {
            Console.WriteLine("{0} is a number.", a);
        }
        else if (char.IsLower(a))
        {
            Console.WriteLine("{0} is lower case string.", a);
        }
        else if (char.IsUpper(a))
        {
            Console.WriteLine("{0} is upper case string.", a);
        }
        else if (char.IsSymbol(a))
        {
            Console.WriteLine("{0} is a symbol.", a);
        }
        else
        {
            Console.WriteLine("{0} is unknown.", a);
        }

    }
}