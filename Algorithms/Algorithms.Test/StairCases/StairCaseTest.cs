using System;
using Algorithms.Exceptions;
using Algorithms.Matrix;
using Algorithms.StairCases;
using Algorithms.Test.Matrix;
using ExpectedObjects;

namespace Algorithms.Test.StairCases
{
    public class StairCaseTest
    {
        private readonly int _n;

        public StairCaseTest()
        {
            _n = 4;
        }

  

        [Theory]
        [InlineData(0)]
        public void InputNullStairCase(int n)
        {
            Assert.Throws<DomainException>(() => StairCasesBuilder.NewAllPropsBuilder(n));
        }

        [Theory]
        [InlineData(4)]
        public void InputSucessStairCase(int n)
        {
           // Assert.Equal(new string[,] { {string.Empty, string.Empty , string.Empty, "#"},
              //  {string.Empty, string.Empty , "#", "#"},
               // {string.Empty, "#" , "#", "#"},
               // {"#", "#" , "#", "#"},}, StairCasesBuilder.NewAllPropsBuilder(n).PrintStairCase());
        }
    }
}

