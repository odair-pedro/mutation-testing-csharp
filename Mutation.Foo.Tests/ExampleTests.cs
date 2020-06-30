using Xunit;

namespace Mutation.Foo.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void Concat_ShouldReturn_CorrectValue()
        {
            var result = Example.ConcatValues("bar");
            Assert.Equal("bar", result);
        }
    }
}