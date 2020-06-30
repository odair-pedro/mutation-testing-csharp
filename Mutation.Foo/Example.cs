namespace Mutation.Foo
{
    public static class Example
    {
        public static string ConcatValues(params string[] values)
        {
            return string.Join(string.Empty, values);
        }
    }
}