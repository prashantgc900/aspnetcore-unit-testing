using LibraryApi.Helpers;
using LibraryApi.UnitTests.Helpers.TestData;

namespace LibraryApi.UnitTests.Helpers
{
    public class StringHelperTests
    {
        private readonly StringHelper _stringHelper;
        public StringHelperTests()
        {
            _stringHelper = new StringHelper();
        }

        [Fact(DisplayName = "IsEmpty With Empty String Returns True")]
        public void IsEmpty_WithEmptyString_ReturnsTrue()
        {
            // Arrange
            //var stringHelper = new StringHelper();

            // Act
            var result = _stringHelper.IsEmpty(string.Empty);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_WithNullString_ReturnsTrue()
        {
            // Arrange
            //var stringHelper = new StringHelper();

            // Act
            var result = _stringHelper.IsEmpty(null);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_WithValidString_ReturnsFalse()
        {
            // Arrange
            //var stringHelper = new StringHelper();

            // Act
            var result = _stringHelper.IsEmpty("Test");

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("Prashant", 1)]
        [InlineData("Prashant GC", 2)]
        [InlineData(" Prashant GC Test Data ", 4)]
        [InlineData("", 0)]
        [MemberData(nameof(GetData))]
        [ClassData(typeof(StringHelperTestData1))]
        public void CountWords_WithMultipleWords_ReturnsCorrectCount(string text, int expectedCount)
        {
            // Arrange
            //var stringHelper = new StringHelper();

            // Act
            var result = _stringHelper.CountWords(text);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact(Skip = "Skipping test for demonstration purpose", DisplayName = "CountWords with null string returns 0")]
        public void CountWords_WithNull_ReturnsCorrectCount()
        {
            // Arrange
            //var stringHelper = new StringHelper();

            // Act
            var result = _stringHelper.CountWords(null);

            // Assert
            Assert.Equal(0, result);
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "One two three four five", 5 };
            yield return new object[] { " One two three four five ", 5 };
            yield return new object[] { "One two three", 3 };
        }
    }
}
