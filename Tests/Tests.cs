using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {

// dotnet test was not working at all so I transferred code into a working directory. not sure why.
// all functions in tests.cs were named ml.CalcRectArea. copy pasted correct function names. naughty naughty!
        
        // Write Unit Tests for all functions for your assigned group

        //Theory needs params for the test function
        [Theory]
        [InlineData(14,3,4)]
        [InlineData(18,4,5)]
        [InlineData(8,-2,-2)]
        [InlineData(20,-5,-5)]

        public void CalcRectPerimeter(int expected, int length, int width){
            //construct if need to
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectPerimeter(length, width);
            Assert.Equal(result, expected);
        }


        [Theory]
        [InlineData(true,1)]
        [InlineData(true,10)]
        [InlineData(false,16)]
        [InlineData(true,91)]
        public void IsTriangularNum(Boolean expected,int num)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.IsTriangularNum(num);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(5,41)]
        [InlineData(10,50)]
        [InlineData(-21,-5)]
        [InlineData(-18,1)]
        public void FarenheitToCelcius(int expected,int farenheit)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.FarenheitToCelcius(farenheit);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(false,"A")]
        [InlineData(true," Geez Matt atleast get the tests right")]
        [InlineData(false, "ffsIThoiughtIdid")] 
        [InlineData(true," ")]
        public void CheckWhiteSpace(Boolean expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CheckWhiteSpace(word);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("I aM tHe BeSt","i am the best")]
        [InlineData("WhO iS yOuR dAdDy", "WHO IS YOUR DADDY")]
        [InlineData("SuH sUh MaTe","sUh SuH mAtE")]
        public void CamelString(string expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CamelString(word);
            Assert.Equal(result, expected);
        }


        [Theory]
        [InlineData(1,"i am the best 3")]
        [InlineData(3, "1s u 4ty 4")]
        [InlineData(0,"I dont believe so")]
        public void CountDigits(int expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CountDigits(word);
            Assert.Equal(result, expected);
        }

    }
}
