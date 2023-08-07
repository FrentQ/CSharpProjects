using System;
using System.Collections.Generic;

namespace StarPyramid
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sp = 4, star = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int b = 1; b <= sp; b++)
                {
                    Console.Write(" ");
                }
                for (int d = 1; d <= star; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
                star = star + 2;
                sp = sp - 1;
            }
        }
    }
}