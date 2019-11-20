using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble
{
    public static class ScrabbleScore
    {
        public static int Score(string input)
        {
            var letters = input.ToLower()
                .ToCharArray();

            int scrabbleScore = 0;

            foreach (char letter in letters)
            {
                scrabbleScore += Scrabble.TryGetValue(letter, out int val) ? val : 0;
            }
            return scrabbleScore;
        }

        public static Dictionary<char, int> Scrabble = new Dictionary<char, int>
        {
            {'a', 1},
            {'e', 1},
            {'i', 1},
            {'o', 1},
            {'u', 1},
            {'l', 1},
            {'n', 1},
            {'r', 1},
            {'s', 1},
            {'t', 1},
            {'d', 2},
            {'g', 2},
            {'b', 3},
            {'c', 3},
            {'m', 3},
            {'p', 3},
            {'f', 4},
            {'h', 4},
            {'v', 4},
            {'w', 4},
            {'y', 4},
            {'k', 5},
            {'j', 8},
            {'x', 8},
            {'q', 10},
            {'z', 10},
        };

    }
}