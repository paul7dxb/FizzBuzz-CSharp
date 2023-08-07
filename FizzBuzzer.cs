
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

            if (IsDivisibleBy(n, 13))
            {
                result = AddFezzBeforeB(result);
            }

            if (IsDivisibleBy(n, 17))
            {
                result.Reverse();
            }

            if (result.Count == 0)
            {
                result.Add(n.ToString());
            }

            return ResultArrToString(result);
        }

        private static string ResultArrToString(List<string> results)
        {
            return String.Join("", results);
        }
        private static bool IsDivisibleBy(int number, int divisor)
        {
            return (number % divisor) == 0;
        }

        private static List<string> AddFezzBeforeB(List<string> result)
        { 
            var newResults = new List<string>(result);
            var indexB = newResults.FindIndex(word => word.StartsWith("B"));
            if (indexB >= 0)
            {
                newResults.Insert(indexB, "Fezz");
            }
            else
            {
                newResults.Add("Fezz");
            }
            return newResults;
        }
    }
}