using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Redrum","murdeR")] //Add test data <-------
        public void Test1(string regular,string expected)
        {      
                Palin p = new Palin();


                string ans = p.Palindrome(regular);

                Assert.Equal(expected, ans);
            
        }
    }
}