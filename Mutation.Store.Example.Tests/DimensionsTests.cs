using System;
using Xunit;

namespace Mutation.Store.Example.Tests
{
    public class DimensionsTests
    {
        [Fact]
        public void ToString_WithCorrectDimensions_ShouldReturn_CorrectValue()
        {
            var dimensions = new Dimensions(10, 10, 10);
            var result = dimensions.ToString();
            
            Assert.Equal("HxWxD: 10x10x10", result);
        }

        [Fact]
        public void Validate_WithIncorrectHeight_ShouldThrowException()
        {
            var dimentions = new Dimensions(0, 10, 10);

            Assert.Throws<Exception>(() => dimentions.Validate());
        }
    }
}