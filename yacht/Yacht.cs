using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

public enum YachtCategory
{
    Ones = 1,
    Twos = 2,
    Threes = 3,
    Fours = 4,
    Fives = 5,
    Sixes = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    LittleStraight = 9,
    BigStraight = 10,
    Choice = 11,
    Yacht = 12,
}

public static class YachtGame
{
    public static int Score(int[] dice, YachtCategory category)
    {
        int score;

        if ((int)category <= 6)
            score = ((int)category * dice.Where(num => num == (int)category).Count());
        else
            switch (category)
	        {
		        case YachtCategory.FullHouse:
                    var pairOrThreeOfKind = dice.Select( x => new { Integer = x, Count = dice.Count(y => y == x) });
                        score = pairOrThreeOfKind.All(x => x.Count == 2 || x.Count == 3) ? pairOrThreeOfKind.Sum(x => x.Integer) : 0;
                break;

                case YachtCategory.FourOfAKind:
                    score = dice.Select((x) => new { Integer = x, Count = dice.Count(y => y == x) }).Where(x => x.Count >= 4).Take(4).Sum(x => x.Integer);
                break;

                case YachtCategory.LittleStraight:
                    score = dice.OrderBy(x => x).SequenceEqual(new[] {1,2,3,4,5}) ? 30 : 0;
                break;

                case YachtCategory.BigStraight:
                    score = dice.OrderBy(x => x).SequenceEqual(new[] {2,3,4,5,6}) ? 30 : 0;
                break;

                case YachtCategory.Choice:
                        score = dice.Sum();
                break;

                case YachtCategory.Yacht:
                        score = dice.Distinct().Count() == 1 ? 50 : 0;
                break;

                default:
                        score = 0;
                break;
	        }

        return score;
         
    }
}

