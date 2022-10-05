using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]       //Add test data <-------
        [InlineData(4, 4, 10, 18)]
        [InlineData(-12, 14, 2, 4)]
        [InlineData(0, 20, 0, 20)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14, 12, 2)]//Add test data <-------
        [InlineData(1561, 1, 1560)]
        [InlineData(29, 0, 29)]
        [InlineData(0, 0, 0)]
        [InlineData(4, -4, 8)]
        public void SubtractTest(int minuend, int subtrhend, int expectedDifference)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var actualDifference = calc.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(4, 4, 16)]//Add test data <-------
        [InlineData(9, 9, 81)]
        [InlineData(0, 142124, 0)]
        [InlineData(42, 0, 0)]
        [InlineData(1, 1, 1)]
        public void MultiplyTest(int num1, int num2, int expectedProduct)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var actualProduct = calc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(27, 9, 3)]//Add test data <-------
        [InlineData(100, 10, 10)]
        [InlineData(20, 1, 20)]
        [InlineData(0, 421, 0)]
        [InlineData(12, 0, 0)]
        public void DivideTest(int num1, int num2, int expectedQuotient)
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var actualQuotient = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expectedQuotient, actualQuotient);
        }

    }
}
