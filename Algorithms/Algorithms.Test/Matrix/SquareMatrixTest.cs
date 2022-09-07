using System;
using Algorithms.AliceBobGame;
using Algorithms.Exceptions;
using Algorithms.Matrix;
using Algorithms.Test.AliceBobGame;
using ExpectedObjects;

namespace Algorithms.Test.Matrix
{
    public class SquareMatrixTest
    {
        private readonly int[,] _input;

        public SquareMatrixTest()
        {
            _input = new int[,] {{ 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 }};
        }

        [Fact]
        public void CanCreateSquareMatrix()
        {
            var squareMatrixExpected = new
            {
                Input = _input,
            };

            var squareMatrix = new SquareMatrix(squareMatrixExpected.Input);

            squareMatrixExpected.ToExpectedObject().ShouldMatch(squareMatrix);
        }


        [Theory]
        [InlineData(null)]
        public void InputNullGame(int[,] input)
        {
            Assert.Throws<DomainException>(() => SquareMatrixBuilder.NewWithAllProps(input));
        }

        [Fact]
        public void InputNotSquareMatrixGame()
        {
            var input = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }};
            Assert.Throws<DomainException>(() => SquareMatrixBuilder.NewWithAllProps(input));
        }

        [Fact]
        public void ResultSucessGame()
        {
            var input = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            Assert.Equal(15,SquareMatrixBuilder.NewWithAllProps(input).ResultSumDiagonal());
        }

        [Fact]
        public void ResultSucessListGame()
        {
            var input = new List<List<int>>();
            input.Add(new List<int>() { 11, 2, 4 });
            input.Add(new List<int>() { 4, 5, 6 });
            input.Add(new List<int>() { 10, 8, -12 });
            var inputs = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            Assert.Equal(15, SquareMatrixBuilder.NewWithAllProps(inputs).ResultSumDiagonal(input));
        }


    }
}

