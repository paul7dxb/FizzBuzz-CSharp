using System;

namespace Fizzbuzz
{

    public class Program
    {
        static void Main(string[] args)
        {

            List<int> gameOptions;


            if (args.Length > 0)
            {
                gameOptions = parseGameArgs(args);
            } else{
                gameOptions = new List<int>{3,5,7,11,13,17};
            }

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


            var fizzBuzzer = new FizzBuzzer(gameOptions);

            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(fizzBuzzer.Fizzbuzz(i));
            }

        }

        private static List<int> parseGameArgs(string[] args)
        {
            var gameOptions = new List<int>();

            foreach (string arg in args)
            {
                try
                {
                    int gameParam = Int32.Parse(arg);
                    gameOptions.Add(gameParam);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{arg}' input.");
                }
            }

            return gameOptions;
        }
    }
}