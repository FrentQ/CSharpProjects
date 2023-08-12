using System;
using System.Collections.Generic;
using System.Formats.Asn1;

namespace CelciusKelvinFahrenheit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter thermometer's unit: 1 for Celcius, 2 for Kelvin and 3 for Fahrenheit.\n");
            int unit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the value measured on the thermometer.\n");
            double value = Convert.ToInt32(Console.ReadLine());

            double C, K, F;
            if (unit == 1)
            {
                K = value + 273.15;
                F = value * 1.8 + 32;

                Console.WriteLine($"\n\n{value}°C = {K}°K = {F}°F");
            }
            else if (unit == 2)
            {
                C = value - 273.15;
                F = (value - 273.15) * 1.8 + 32;

                Console.WriteLine($"\n\n{value}°K = {C}°C = {F}°F");
            }
            else
            {
                C = (value - 32) / 1.8;
                K = (value - 32) * 5 / 9 + 273.15;

                Console.WriteLine($"\n\n{value}°F = {C}°C = {K}°K");
            }
        }
    }
}