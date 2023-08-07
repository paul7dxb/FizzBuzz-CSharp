using System;

namespace Fizzbuzz
{

    public class Program
    {
        static void Main(string[] args)
        {
            int max = 100;

            var fizzBuzzer = new FizzBuzzer();

            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(fizzBuzzer.Fizzbuzz(i));
            }

        }

    }
}