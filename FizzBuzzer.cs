
namespace Fizzbuzz
{

    public class FizzBuzzer
    {
        public string Fizzbuzz(int n)
        {
            string result = "";
            if (IsDivisibleBy(n, 3))
            {
                result += "Fizz";
            }
            if (IsDivisibleBy(n, 5))
            {
                result += "Buzz";
            }
            if (IsDivisibleBy(n, 7))
            {
                result += "Bang";
            }
            if (IsDivisibleBy(n, 11))
            {
                result = "Bong";
            }

            if (result == "")
            {
                result = n.ToString();
            }
            return result;
        }
        private static bool IsDivisibleBy(int number, int divisor)
        {
            return (number % divisor) == 0;
        }
    }
}