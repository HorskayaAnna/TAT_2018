using System.Text;
using Xunit;
using DevTask2;

namespace DEV2Tests
{
    public class GetterStringWithEvenSymbolsTests
    {
        [Fact]
        public void GetEvenPositionsStringBuilder_IsCorrectWorkOfMethodWithEvenLength()
        {
            StringBuilder inputString = new StringBuilder("qwqwqw");
            string expected = "qqq";

            GetterStringWithEvenSymbols evener = new GetterStringWithEvenSymbols(inputString);
            string actual = evener.GetEvenPositionsStringBuilder().ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetEvenPositionsStringBuilder_IsCorrectWorkOfMethodWithOddLength()
        {
            StringBuilder inputString = new StringBuilder("qwqwq");
            string expected = "qqq";

            GetterStringWithEvenSymbols evener = new GetterStringWithEvenSymbols(inputString);
            string actual = evener.GetEvenPositionsStringBuilder().ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetEvenPositionsStringBuilder_IsEmptyString()
        {
            StringBuilder inputString = new StringBuilder(string.Empty);
            string expected = string.Empty;

            GetterStringWithEvenSymbols evener = new GetterStringWithEvenSymbols(inputString);
            string actual = evener.GetEvenPositionsStringBuilder().ToString();

            Assert.Equal(expected, actual);
        }
    }
}
