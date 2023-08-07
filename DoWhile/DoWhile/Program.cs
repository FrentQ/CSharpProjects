using System;
using System.Collections.Generic;

namespace DoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit number.");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            do
            {
                Console.Write("{0,-5}", i);
                i++;
            } while (i <= num);
        }
    }
}