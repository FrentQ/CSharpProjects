using System;
using System.Collections;

namespace Average
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for calculate their average. If you enter 0, program ends.");

            ArrayList average = new ArrayList();

            while (true)
            {
                double a = Convert.ToSingle(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else
                {
                    average.Add(a);
                }
            }
                double sum = 0;

                foreach (double i in average)
                {
                    sum = sum + i;
                }

                Console.WriteLine($"Average = {sum / average.Count}");
        }
    }
}