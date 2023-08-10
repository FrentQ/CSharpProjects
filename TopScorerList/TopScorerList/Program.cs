using System;
using System.Collections;
using System.Collections.Generic;

namespace TopScorerList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var topScorerList = new ArrayList();

            Console.WriteLine("Enter top 10 scorer footballers and their goal numbers.");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}. Footballer's Name:");
                string name = Console.ReadLine();
                Console.WriteLine($"{i}. Footballer's Score Number:");
                int goal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                topScorerList.Add(name);
                topScorerList.Add(goal);
            }
            Console.WriteLine("Name\t\t\tGoal Number");
            Console.WriteLine("----\t\t\t-----------");

            for (int i = 0; i < 20; i=i+2)
            {
                Console.WriteLine("{0}\t\t{1}", topScorerList[i], topScorerList[i+1]);
                Console.WriteLine("\n");
            }
        }
    }
}