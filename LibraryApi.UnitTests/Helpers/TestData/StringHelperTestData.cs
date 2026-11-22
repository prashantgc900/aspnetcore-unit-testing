using System.Collections;

namespace LibraryApi.UnitTests.Helpers.TestData
{
    public class StringHelperTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "One two three four five", 5 };
            yield return new object[] { " One two three four five ", 5 };
            yield return new object[] { "One two three", 3 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
