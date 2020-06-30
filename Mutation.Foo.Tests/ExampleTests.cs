using Xunit;

namespace Mutation.Foo.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ConcatValues_ShouldReturn_CorrectValue()
        {
            var result = Example.ConcatValues("foo", "bar");
            Assert.Equal("foobar", result);
        }

        [Fact]
        public void RemoveChars_ShouldReturn_CorrectValue()
        {
            var result = Example.RemoveChars("123456789");
            Assert.Equal(string.Empty, result);
        }
    }
}