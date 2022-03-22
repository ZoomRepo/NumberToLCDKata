using Xunit;

namespace NumberToLCDKata
{
    public class NumberToLCDTests
    {
        [Fact]
        public void Given0ReturnsDigital0()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(0);

            Assert.Equal("__\n|  |\n|__|", result);

        }
    }
}