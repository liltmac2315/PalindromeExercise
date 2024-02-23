using System;
using System.Security.Cryptography.X509Certificates;
using ExampleForPalindrome;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar",true)]
        [InlineData("mom",true)]
        public void MyTest(string word, bool expected) 
        { 
            //arrange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
