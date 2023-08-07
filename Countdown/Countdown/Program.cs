using System;
using System.Collections.Generic;

namespace Countdown
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Countdown started.");
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}