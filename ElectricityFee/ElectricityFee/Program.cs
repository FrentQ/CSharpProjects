using System;
using System.Collections.Generic;

namespace ElectricityFee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of electricity usage.");
            double usg = Convert.ToDouble(Console.ReadLine());
            double fee;

            if (usg <= 240)
            {
                fee = usg * 1.48;
            }
            else
            {
                fee = usg * 2.22;
            }

            Console.WriteLine($"\nElectricity usage: {usg}kWh\nElectricity fee: {fee}TL");
        }
    }
}