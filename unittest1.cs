using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            calculator ti84=new calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int ans=ti84.add(int num1,int num2);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
           calculator ti84=new calculator();
           int ans=ti84.sub(minuend,subtrahend);
            //Act
           assert.equal(ans,expected);
            //Assert

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            calculator ti84=new calculator();
            //Act
            int ans=ti84.mult(int num1,int num2);
            //Assert
             assert.equal(ans,expected);
        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            calculator ti84=new calculator();
            //Act
            int ans=ti84.div(int num1,int num2);
            //Assert
            assert.equal(ans,expected);

        }

    }
}
