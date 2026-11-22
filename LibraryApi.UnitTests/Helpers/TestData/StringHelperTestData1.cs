namespace LibraryApi.UnitTests.Helpers.TestData
{
    public class StringHelperTestData1 : TheoryData<string, int>
    {
        public StringHelperTestData1()
        {
            Add("One two three four five", 5);
            Add(" One two three four five ", 5);
            Add("One two three", 3);
        }
    }
}
