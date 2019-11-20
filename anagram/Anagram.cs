using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    public class Anagram
    {

        private readonly string keyWord;
        private readonly IEnumerable<char> resultsList;

        public Anagram(string baseWord)
        {
            keyWord = baseWord.ToLower();
            resultsList = resultsList.OrderBy(c => c).ToList();
        }

        public string[] FindAnagrams(string[] words)
        {
            return words
                   .Where(word => word.ToLower() != keyWord)
                   .Where(word => Enumerable.SequenceEqual(word.ToLower().OrderBy(c => c), resultsList))
                   .OrderBy(word => word)
                   .ToArray();
        }
    }
}