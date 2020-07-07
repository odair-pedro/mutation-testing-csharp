using System;
using Xunit;

namespace Mutation.Store.Example.Tests
{
    public class DimensionsTests
    {
        [Theory]
        [InlineData(10, 10, 10)]
        public void ToString_WithCorrectDimensions_ShouldReturn_CorrectValue(decimal height, decimal width, decimal depth)
        {
            var dimensions = new Dimensions(height, width, depth);
            var result = dimensions.ToString();
            
            Assert.Equal($"HxWxD: {height}x{width}x{depth}", result);
        }
        
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 10, 10)]
        [InlineData(10, 0, 10)]
        [InlineData(10, 10, 0)]
        public void ToString_WithIncorrectDimensions_ShouldReturn_Message(decimal height, decimal width, decimal depth)
        {
            var dimensions = new Dimensions(height, width, depth);
            var result = dimensions.ToString();
            
            Assert.Equal("No dimensions", result);
        }

        [Fact]
        public void Validate_WithIncorrectHeight_ShouldThrowException()
        {
            var dimentions = new Dimensions(0, 10, 10);

            Assert.Equal("Height can not be equal or less than zero", Assert.Throws<Exception>(() => dimentions.Validate()).Message);
        }
        
        [Fact]
        public void Validate_WithIncorrectWidth_ShouldThrowException()
        {
            var dimentions = new Dimensions(10, 0, 10);

            Assert.Equal("Width can not be equal or less than zero", Assert.Throws<Exception>(() => dimentions.Validate()).Message);
        }
        
        [Fact]
        public void Validate_WithIncorrectDepth_ShouldThrowException()
        {
            var dimentions = new Dimensions(10, 10, 0);

            Assert.Equal("Depth can not be equal or less than zero", Assert.Throws<Exception>(() => dimentions.Validate()).Message);
        }
    }
}