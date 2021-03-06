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
            var result = Example.CountWordsInText("foo bar");
            
            Assert.Equal(2, result);
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
        
        [Theory]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void CalculateFibonacci_WithMaxValue_LastValue_ShouldBe_Eigth(int maxValue)
        {
            var result = Example.CalculateFibonacci(maxValue);
            
            Assert.Equal(8, result[^1]);
        }
        
        [Theory]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void CalculateFibonacci_WithMaxValue_ShouldReturn_CorrectValues(int maxValue)
        {
            var result = Example.CalculateFibonacci(maxValue);
            
            Assert.Equal(new[] { 0, 1, 1, 2, 3, 5, 8 }, result);
        }
        
        [Fact]
        public void CalculateFibonacci_WithMaxOne_ShouldReturn_CorrectValues()
        {
            var result = Example.CalculateFibonacci(1);
            
            Assert.Equal(new[] { 0, 1, 1 }, result);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void CalculateFibonacci_WithMaxValue_ShouldReturn_Default(int maxValue)
        {
            var result = Example.CalculateFibonacci(maxValue);
            
            Assert.Equal(new[] { 0, 1, 1 }, result);
        }
    }
}