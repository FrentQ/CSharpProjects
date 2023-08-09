using System;
using System.Collections.Generic;

namespace MiniDataSaver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students.");
            int a = Convert.ToInt32(Console.ReadLine());
            string[,] data = new string[a, 2];

            Console.WriteLine("Enter students' names.");
            for (int i = 0; i < a; i++)
                data[i, 0] = Console.ReadLine();
            
            Console.WriteLine("Enter students' nationality.");
            for (int i = 0; i < a; i++)
                data[i, 1] = Console.ReadLine();

            int count = 0;
            Console.WriteLine("Name\tNationality");
            Console.WriteLine("----\t-----------");
            foreach (string i in data)
            {
                Console.Write($"{i}\t");
                count++;
                if (count % 2 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}