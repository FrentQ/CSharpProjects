using System;
using System.Collections.Generic;

namespace SquareCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] rtdef;
            rtdef = new int[5];

            Console.WriteLine("Enter the numbers you want to calculate their squares in order.");

            for (int i = 0; i < 5; i++)
            {
                rtdef[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] sqdef;
            sqdef = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sqdef[i] = rtdef[i] * rtdef[i];
            }
            Console.WriteLine("\nNumber\t\tSquare");
            Console.WriteLine("------\t\t------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t\t{1}", rtdef[i], sqdef[i]);
            }
        }
    }
}