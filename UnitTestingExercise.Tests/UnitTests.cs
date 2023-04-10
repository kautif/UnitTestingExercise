using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] // X Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // X? create a Calculator object
            Calculator calc = new Calculator();

            //Act
                // X call the Add method that is located in the Calculator class
                // X and store its result in a variable named actual
                var actual = calc.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 5, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //X Arrange
            Calculator calc = new Calculator();

            // X Act
            var actual = calc.Subtract(minuend, subtrahend);

            // X Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();
            //Act
            var actual = calc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);    

        }

    }
}
