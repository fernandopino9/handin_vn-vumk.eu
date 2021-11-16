using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Please enter temperature in Fahrenheit:); double tempF = double.Parse(Console.ReadLine()); Console.WriteLine("Please enter temperature in Celsius:"); double tempC = double.Parse(Console.ReadLine()); double fahrenheitTocelsius = (tempF - 32) * 5 / 9; double celsiusTofahrenheit = (tempC * 9 / 5) + 32;

            Console.WriteLine("The temperature converted from Fahrenheit to Celsius is:" +
                "+ fahrenheitTocelsius)
                Console, WriteLine(The temperature converted from Celsius to Fahrenheit is:
                    "+ celsiusTofahrenheit)                                        


        }
    }
}
