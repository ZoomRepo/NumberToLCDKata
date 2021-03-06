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
        private const string three = @" _ 
 _|
 _|";
        private const string four = @"   
|_|
  |";
        private const string five = @" _ 
|_
 _|";
        private const string six = @" _ 
|_ 
|_|";
        private const string seven = @" _ 
  |
  |";
        private const string eight = @" _ 
|_|
|_|";
        private const string nine = @" _ 
|_|
 _|";
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
        [Fact]
        public void Given3ReturnsDigital3()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(3);

            Assert.Equal(three, result);

        }
        [Fact]
        public void Given4ReturnsDigital4()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(4);

            Assert.Equal(four, result);

        }        
        [Fact]
        public void Given5ReturnsDigital5()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(5);

            Assert.Equal(five, result);

        }
        [Fact]
        public void Given6ReturnsDigital6()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(6);

            Assert.Equal(six, result);

        }
        [Fact]
        public void Given7ReturnsDigital7()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(7);

            Assert.Equal(seven, result);

        }
        [Fact]
        public void Given8ReturnsDigital8()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(8);

            Assert.Equal(eight, result);

        }        
        [Fact]
        public void Given9ReturnsDigital9()
        {
            NumberToLCD numberToLCD = new NumberToLCD();

            var result = numberToLCD.GetDigital(9);

            Assert.Equal(nine, result);

        }

    }
}