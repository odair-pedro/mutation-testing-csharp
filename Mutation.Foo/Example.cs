using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mutation.Foo
{
    public static class Example
    {
        public static string ConcatValues(params string[] values)
        {
            return string.Join(string.Empty, values);
        }

        public static string RemoveChars(string value)
        {
            return Regex.Match(value, @"\d+").Value;
        }

        public static double SumTwoValues(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double MultiplyTwoValues(double value1, double value2)
        {
            return value1 * value2;
        }

        public static IEnumerable<double> FilterValuesBiggerThan(double valueToCompare, params double[] valuesToFilter)
        {
            return valuesToFilter
                .Where(val => val > valueToCompare);
        }

        public static bool VerifyNumberIsPrime(uint number)
        {
            if (number <= 1)
                return false;

            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        
        public static bool VerifyNumberIsComposite(uint number)
        {
            if (number <= 1)
                return false;

            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return true;
            }

            return false;
        }
        
        public static bool VerifyNumberIsNatural(int number)
        {
            return number >= 0;
        }
    }
}