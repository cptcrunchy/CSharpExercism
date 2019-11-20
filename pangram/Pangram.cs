using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => input.ToLower().Distinct().Where(c => char.IsLetter(c)).Count() == 26;

}
