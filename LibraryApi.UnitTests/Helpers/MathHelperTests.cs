using LibraryApi.Helpers;
using Xunit.Abstractions;

namespace LibraryApi.UnitTests.Helpers
{
    public class MathHelperTests
    {
        private readonly MathHelper _mathHelper;
        private readonly ITestOutputHelper _outputHelper;

        public MathHelperTests(ITestOutputHelper outputHelper)
        {
            _mathHelper = new MathHelper();
            _outputHelper = outputHelper;
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

            _outputHelper.WriteLine("Adding {0} and {1} gives {2}", a, b, result);

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
