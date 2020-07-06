using Xunit;

namespace Mutation.Foo.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ConcatValues_ShouldReturn_CorrectValue()
        {
            var result = Example.ConcatValues("foo");
            
            Assert.Equal("foo", result);
        }

        [Fact]
        public void RemoveChars_ShouldReturn_CorrectValue()
        {
            var result = Example.RemoveChars("123456789");
            
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void SumTwoValues_ShouldReturn_CorrectValue()
        {
            var result = Example.SumTwoValues(1, 0);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void MultiplyTwoValues_ShouldReturn_CorrectValue()
        {
            var result = Example.MultiplyTwoValues(2, 1);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void FilterValuesBiggerThan_ShouldReturn_CorrectValues()
        {
            var result = Example.FilterValuesBiggerThan(50, 100, 200, 300, 400);
            
            Assert.Collection(result,
                first => Assert.Equal(100, first),
                second => Assert.Equal(200, second),
                third => Assert.Equal(300, third),
                fourth => Assert.Equal(400, fourth));
        }

        [Fact]
        public void VerifyNumberIsPrime_ShouldReturn_True()
        {
            var result = Example.VerifyNumberIsPrime(3);
            
            Assert.True(result);
        }
        
        [Fact]
        public void VerifyNumberIsComposite_ShouldReturn_True()
        {
            var result = Example.VerifyNumberIsComposite(9);
            
            Assert.True(result);
        }

        [Fact]
        public void VerifyNumberIsNatural_ShouldReturn_True()
        {
            var result = Example.VerifyNumberIsNatural(100);
            
            Assert.True(result);
        }
    }
}