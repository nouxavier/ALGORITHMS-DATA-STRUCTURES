using System;
using Algorithms.AliceBobGame;
using Algorithms.Exceptions;
using Algorithms.Test.Sum;
using ExpectedObjects;

namespace Algorithms.Test.AliceBobGame
{
    public class GameTest
    {
        private readonly int[] _playerA;
        private readonly int[] _playerB;

        public GameTest()
        {
            _playerA = new int[] { 1, 2, 3 };
            _playerB = new int[] { 3, 2, 1 };
        }

        [Fact]
        public void CanCreateGame()
        {
            var gameExpected = new
            {
                PlayerA = _playerA,
                PlayerB = _playerB,
            };

            var game = new Game(gameExpected.PlayerA, gameExpected.PlayerB);

            gameExpected.ToExpectedObject().ShouldMatch(game);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[1] {1 }, new int[2] {1,2})]
        public void InputNullGame(int[] playerA, int[] playerB)
        {
            Assert.Throws<DomainException>(() => GameBuilder.NewWithAllProps(playerA,playerB));
        }

        [Theory]
        [InlineData(new int[3] { 1,2,3 }, new int[3] { 3,2,1})]
        public void ResultGame1Sucess(int[] playerA, int[] playerB)
        {
            var result = GameBuilder.NewWithAllProps(playerA, playerB).ResultGame();
            Assert.Equal(new int[2] { 1, 1 }, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, new int[3] { 3, 2, 1 })]
        public void ResultGame1Fail(int[] playerA, int[] playerB)
        {
            var result = GameBuilder.NewWithAllProps(playerA, playerB).ResultGame();
            Assert.NotEqual(new int[2] { 1, 2 }, result);
        }

        [Theory]
        [InlineData(new int[3] { 17, 28, 30 }, new int[3] { 99, 16, 8 })]
        public void ResultGame2Sucess(int[] playerA, int[] playerB)
        {
            var result = GameBuilder.NewWithAllProps(playerA, playerB).ResultGame();
            Assert.Equal(new int[2] { 2, 1 }, result);
        }

        [Theory]
        [InlineData(new int[3] { 17, 28, 30 }, new int[3] { 99, 16, 8 })]
        public void ResultGame2Fail(int[] playerA, int[] playerB)
        {
            var result = GameBuilder.NewWithAllProps(playerA, playerB).ResultGame();
            Assert.NotEqual(new int[2] { 1, 2 }, result);
        }
    }
}

