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
        public void CountWordsInText_ShouldReturn_CorrectValue()
        {
            var result = Example.CountWordsInText("foo");
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void RemoveCharsAndSymbols_ShouldReturn_CorrectValue()
        {
            var result = Example.RemoveCharsAndSymbols("abcdef_!@*&*@(*%1234");
            
            Assert.Equal("1234", result);
        }

        [Fact]
        public void SumTwoValues_ShouldReturn_CorrectValue()
        {
            var result = Example.SumTwoValues(1, 1);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiplyTwoValues_ShouldReturn_CorrectValue()
        {
            var result = Example.MultiplyTwoValues(2, 2);
            
            Assert.Equal(4, result);
        }

        [Fact]
        public void FilterValuesBiggerThan_ShouldReturn_CorrectValues()
        {
            var result = Example.FilterValuesBiggerThan(50, 1, 50, 100, 200, 300, 400);
            
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

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        public void VerifyNumberIsPrime_ShouldReturn_False(uint number)
        {
            var result = Example.VerifyNumberIsPrime(number);
            
            Assert.False(result);
        }
        
        [Fact]
        public void VerifyNumberIsComposite_ShouldReturn_True()
        {
            var result = Example.VerifyNumberIsComposite(9);
            
            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void VerifyNumberIsComposite_ShouldReturn_False(uint number)
        {
            var result = Example.VerifyNumberIsComposite(number);
            
            Assert.False(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void VerifyNumberIsNatural_ShouldReturn_True(int number)
        {
            var result = Example.VerifyNumberIsNatural(number);
            
            Assert.True(result);
        }
        
        [Fact]
        public void VerifyNumberIsNatural_ShouldReturn_False()
        {
            var result = Example.VerifyNumberIsNatural(-100);
            
            Assert.False(result);
        }
        
        [Fact]
        public void CalculateFibonacci_WithMaxTen_LasValue_ShouldBe_Eigth()
        {
            var result = Example.CalculateFibonacci(10);
            
            Assert.Equal(8, result[^1]);
        }
    }
}