using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";

            do
            {
                Console.WriteLine("What type of conversion do you want to do?");
                Console.WriteLine("Farenheit to Celsius = ftc");
                Console.WriteLine("Celsius to Farenheit = ctf");
                Console.WriteLine("Exit = None");
                bool parseSuccess = false;
                double tempValue = 0;
                double result = 0;

                option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "ftc":

                        Console.Write("Enter the value Farenheit value you want to convert to Celsius:");
                        parseSuccess = double.TryParse(Console.ReadLine(), out tempValue);

                        while (parseSuccess == false)
                        {
                            Console.WriteLine("Please enter a valid numeric value\n");
                            parseSuccess = double.TryParse(Console.ReadLine(), out tempValue);
                        }

                        result = TempConverter.FahrenheitToCelsius(tempValue);
                        Console.WriteLine($"{tempValue} °F = {result} °C");
                        Console.WriteLine($"============================================\n");

                        break;

                    case "ctf":

                        Console.Write("Enter the value Celsius value you want to convert to Farenheit:");
                        parseSuccess = double.TryParse(Console.ReadLine(), out tempValue);

                        while (parseSuccess == false)
                        {
                            Console.WriteLine("Please enter a valid numeric value\n");
                            parseSuccess = double.TryParse(Console.ReadLine(), out tempValue);
                        }

                        result = TempConverter.CelsiusToFahrenheit(tempValue);
                        Console.WriteLine($"{tempValue} °C = {result} °F");
                        Console.WriteLine($"============================================\n");

                        break;

                    case "none":
                        break;

                    default:
                        Console.WriteLine("Please enter one of the specified options.");
                        Console.WriteLine($"============================================\n");
                        break;
                }

            } while (option != "none");
        }
    }
}
