using System;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(params double[] sides) => IsValidTriangle(sides) && !IsIsosceles(sides);
    public static bool IsIsosceles(params double[] sides) => IsValidTriangle(sides) && IsTwoSidesEqual(sides);
    public static bool IsEquilateral(params double[] sides) => IsValidTriangle(sides) && IsAllSidesEqual(sides);
    public static bool IsAllSidesEqual(params double[] sides) => sides.All(side => side.Equals(sides[0]));
    public static bool IsDegenerate(params double[] sides) => IsValidTriangle(sides) || HasTwoEqualSides(sides);

    public static bool IsTwoSidesEqual(params double[] sides) =>
        sides[0] == sides[1] ||
        sides[0] == sides[2] ||
        sides[1] == sides[2];

    public static bool HasTwoEqualSides(params double[] sides) =>
        (sides[0] + sides[1] == sides[2]) ||
        (sides[0] + sides[2] == sides[1]) ||
        (sides[1] + sides[2] == sides[0]);

    public static bool IsValidTriangle(params double[] sides) =>
        sides[0] + sides[1] > sides[2] &&
        sides[1] + sides[2] > sides[0] &&
        sides[2] + sides[0] > sides[1];

}