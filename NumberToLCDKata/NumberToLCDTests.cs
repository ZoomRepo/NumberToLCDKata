using Xunit;

namespace NumberToLCDKata
{
    public class NumberToLCDTests
    {
        private const string zero = @"__
|  |
|__|";
         private const string one = @"    
   |
   |";

        [Fact]
        public void Given0ReturnsDigital0()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(0);

            Assert.Equal(zero, result);

        }
        [Fact]
        public void Given1ReturnsDigital1()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(1);

            Assert.Equal(one, result);

        }
    }
}