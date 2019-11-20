using System;
using System.Text;
using System.Collections.Generic;

public static class TwelveDays
{
    private static readonly List<(string position, string verse)> lyrics = new List<(string, string)>
    {
        ("first", "a Partridge in a Pear Tree."),
        ("second", "two Turtle Doves, "),
        ("third", "three French Hens, "),
        ("fourth", "four Calling Birds, "),
        ("fifth", "five Gold Rings, "),
        ("sixth", "six Geese-a-Laying, "),
        ("seventh", "seven Swans-a-Swimming, "),
        ("eighth", "eight Maids-a-Milking, "),
        ("ninth", "nine Ladies Dancing, "),
        ("tenth", "ten Lords-a-Leaping, "),
        ("eleventh", "eleven Pipers Piping, "),
        ("twelfth", "twelve Drummers Drumming, ")
    };

    public static string Recite(int verseNumber)
    {
        var lyric = new StringBuilder();
       
        lyric.AppendFormat("On the {0} day of Christmas my true love gave to me: {1}", lyrics[verseNumber -1].position, lyrics[verseNumber - 1].verse);
        
        for(int i = verseNumber - 2; i > 0; i--)
        {
            lyric.Append($"{lyrics[i].verse}");
        }

        if (verseNumber >= 2)
        {
            lyric.Append($"and {lyrics[0].verse}");
        }
                             
        return lyric.ToString().Trim();
       
    }

    public static string Recite(int startVerse, int endVerse)
    {
       var lyric = new StringBuilder();
        for (int i = startVerse; i <= endVerse; i++)
		{
            lyric.Append(Recite(i)).Append("\n");
		}
        return lyric.ToString().Trim();
    }
}