using Xunit;

namespace NumberToLCDKata
{
    public class NumberToLCDTests
    {
        private const string zero = @" _ 
| |
|_|";
         private const string one = @"   
 | 
 | ";
        private const string two = @" _ 
 _|
|_";

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
        [Fact]
        public void Given2ReturnsDigital2()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(2);

            Assert.Equal(two, result);

        }
    }
}