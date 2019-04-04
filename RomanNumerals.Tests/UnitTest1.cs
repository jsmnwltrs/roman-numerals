using System;
using Xunit;

namespace RomanNumerals.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void providing_1_should_output_I()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 1;
            var expectedResult = "I";
            
            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_2_should_output_II()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 2;
            var expectedResult = "II";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_3_should_output_III()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 3;
            var expectedResult = "III";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_4_should_output_IV()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 4;
            var expectedResult = "IV";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void providing_5_should_output_V()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 5;
            var expectedResult = "V";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_6_should_output_VI()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 6;
            var expectedResult = "VI";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_7_should_output_VII()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 7;
            var expectedResult = "VII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_8_should_output_VIII()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 8;
            var expectedResult = "VIII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_9_should_output_IX()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 9;
            var expectedResult = "IX";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_10_should_output_X()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 10;
            var expectedResult = "X";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_11_should_output_XI()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 11;
            var expectedResult = "XI";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_12_should_output_X()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 12;
            var expectedResult = "XII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_13_should_output_XIII()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 13;
            var expectedResult = "XIII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_14_should_output_XIV()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 14;
            var expectedResult = "XIV";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_15_should_output_XV()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 15;
            var expectedResult = "XV";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_16_should_output_XVI()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 16;
            var expectedResult = "XVI";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_17_should_output_XVII()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 17;
            var expectedResult = "XVII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_18_should_output_XVIII()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 18;
            var expectedResult = "XVIII";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void providing_19_should_output_XIX()
        {
            //Arrange
            var romanNumeralGenerator = new RomanNumeralGenerator();
            var input = 19;
            var expectedResult = "XIX";

            //Act
            var actualResult = romanNumeralGenerator.NumberToRomanNumeral(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
