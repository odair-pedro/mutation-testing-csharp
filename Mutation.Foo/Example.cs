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
            return Regex.Match(value, @"\D+").Value;
        }
    }
}