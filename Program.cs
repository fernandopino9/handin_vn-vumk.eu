using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            public static string FirstCharToUpper(this string input)
            {
                var result = input.First().ToString().ToUpper() + input.Substring(1);
                return result;
            }
            {

                Console.WriteLine("Please enter a word");

                string word = Console.ReadLine();

                Console.WriteLine(FirstCharToUpper(word));

                Console.WriteLine("Please enter a sentence");

                string sentence = Console.ReadLine();

            }
        }
}
