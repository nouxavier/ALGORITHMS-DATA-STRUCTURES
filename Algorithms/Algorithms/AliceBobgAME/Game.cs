using System;
using Algorithms.Exceptions;

namespace Algorithms.AliceBobGame
{
    public class Game
    {
        public int[] PlayerA { get; private set; }
        public int[] PlayerB { get; private set; }
        const string MSGA = "Input player A must be greater than zero";
        const string MSGB = "Input player B must be greater than zero";
        const string MSGAB = "Input player A and player B must be equals";

        public Game(int[] playerA, int[] playerB)
        {
            if (playerA == null || playerA.Length <= 0)
                throw new DomainException(MSGA);

            if (playerB == null || playerB.Length <= 0)
                throw new DomainException(MSGB);

            if (playerA.Length != playerB.Length)
                throw new DomainException(MSGAB);

            PlayerA = playerA;
            PlayerB = playerB;

        }

        public int[] ResultGame()
        {
            var result = new int[2];
            for(int i= 0; i<= PlayerA.Length - 1; i++)
            {
                if (PlayerA[i] > PlayerB[i])
                    result[0] = result[0] + 1;
                else if (PlayerA[i] < PlayerB[i])
                    result[1] = result[1] + 1;
            }

            return result;
        }

        public List<int> ResultGameList(List<int> a, List<int> b)
        {
            var result = new int[2];
            for (int i = 0; i <= a.Count - 1; i++)
            {
                if (a.ElementAt(i) > b.ElementAt(i))
                    result[0] = result[0] + 1;
                else if (a.ElementAt(i) < b.ElementAt(i))
                    result[1] = result[1] + 1;
            }

            return result.ToList();
        }


    }
}

