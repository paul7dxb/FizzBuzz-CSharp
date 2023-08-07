using System;

namespace Fizzbuzz
{

    public class Program
    {
        static void Main(string[] args)
        {
            int max = 100;

            Console.Write("Enter max number to use: ");
            string userNumber = Console.ReadLine();

            try
            {
                max = Int32.Parse(userNumber);
                Console.WriteLine($"FizzBuzz being played up to '{userNumber}'\n");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{userNumber}' input. Using default value of 100...");
            }


            var fizzBuzzer = new FizzBuzzer();

            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(fizzBuzzer.Fizzbuzz(i));
            }

        }

    }
}