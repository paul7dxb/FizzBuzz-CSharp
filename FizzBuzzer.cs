
namespace Fizzbuzz
{

    public class FizzBuzzer
    {
        public string Fizzbuzz(int n)
        {
            List<string> result = new List<string>();
            if (IsDivisibleBy(n, 3))
            {
                result.Add("Fizz");
            }
            if (IsDivisibleBy(n, 5))
            {
                result.Add("Buzz");
            }
            if (IsDivisibleBy(n, 7))
            {
                result.Add("Bang");

            }
            if (IsDivisibleBy(n, 11))
            {
                result.Clear();
                result.Add("Bong");
            }

            if (result.Count == 0)
            {
                result.Add(n.ToString());
            }

            return ResultArrToString(result);
        }

        private string ResultArrToString(List<string> results){
            return String.Join("", results);
        }
        private static bool IsDivisibleBy(int number, int divisor)
        {
            return (number % divisor) == 0;
        }
    }
}