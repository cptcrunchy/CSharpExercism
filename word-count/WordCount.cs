using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExercismsCSharp
{
    public static class WordCount
    {
        public static IDictionary<string, int> CountWords(string phrase) =>
            Regex.Matches(phrase.ToLower(), @"(?:\w+?'\w+|\w+|\d)")
                .Select(match => match.Value)
                .GroupBy(word => word)
                .ToDictionary(g => g.Key, g => g.Count());
    }
}