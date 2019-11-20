using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word) => word
        .Where(char.IsLetter)
        .GroupBy(char.ToLower)
        .All(uniqueChar => uniqueChar.Count() == 1);
}
