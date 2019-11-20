using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) => phrase
        .Replace("-", " ")
        .Replace(",", " ")
        .Replace("_", "")
		.Split(' ')
		.Where(word => !string.IsNullOrWhiteSpace(word))
		.ToList()
		.Aggregate("", (acronym, word) => acronym + word.First())
        .ToUpper();
}