using System;
using System.Diagnostics;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(5,2,7,14)]
        [InlineData(12, 15, 10, 37)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(3,5,7,15)]
        [InlineData(1, 5, 0,6)]
        [InlineData(6, 8, 4, 18)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
             var calculator = new Calculator();
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(15, 8, 7)]
        [InlineData(6, 2, 4)]
        [InlineData(72, 12, 60)]
        [InlineData(3, 8, -5)]
        [InlineData(5, 12, -7)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            int actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 1, 6)]
        [InlineData(5, 6, 30)]
        [InlineData(7, 4, 28)]
        [InlineData(8, 5, 40)]
        [InlineData(4, 4, 16)]
        [InlineData(50, 2, 100)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            int actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(20, 2, 10)]
        [InlineData(9, 3, 3)]
        [InlineData(30, 15, 2)]
        [InlineData(7, 3, 2.5)]
        [InlineData(25, 5, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            int actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
