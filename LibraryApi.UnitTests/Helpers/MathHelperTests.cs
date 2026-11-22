using LibraryApi.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApi.UnitTests.Helpers
{
    public class MathHelperTests
    {
        private readonly MathHelper _mathHelper;

        public MathHelperTests()
        {
            _mathHelper = new MathHelper();
        }

        [Fact]
        [Trait("category", "addition")]
        public void Add_WithPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = _mathHelper.Add(a, b);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        [Trait("category", "addition")]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -1;
            int b = -2;

            // Act
            int result = _mathHelper.Add(a, b);

            // Assert
            Assert.Equal(-3, result);
        }

        [Fact]
        [Trait("category", "subraction")]
        public void Subract_WithPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = _mathHelper.Subtract(a, b);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        [Trait("category", "subraction")]
        public void Add_WithNegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = -1;
            int b = -2;

            // Act
            int result = _mathHelper.Subtract(a, b);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
