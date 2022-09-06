using System;
using Algorithms.AliceBobGame;

namespace Algorithms.Test.AliceBobGame
{
    public class GameBuilder
    {
        public static Game NewWithAllProps(int[] playerA, int[] playerB)
        {
            return new Game(playerA, playerB);
        }
    }
}

