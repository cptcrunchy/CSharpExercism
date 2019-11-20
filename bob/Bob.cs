using System;
using System.Linq;


public static class Bob
{

    public static string Response(string statement)
    {
        var bobsResponse = string.Empty;

		if(statement.IsSilence())
		{
			bobsResponse = "Fine. Be that way!";
		}
		else if(statement.IsShouting() && statement.IsQuestion())
		{
			bobsResponse = "Calm down, I know what I'm doing!";
		}
		else if(statement.IsShouting())
		{
			bobsResponse = "Whoa, chill out!";
		}
		else if(statement.IsQuestion())
		{
			bobsResponse = "Sure.";
		}
		else{
			bobsResponse = "Whatever.";
		}

		return bobsResponse;
       
    }
    
    private static bool IsQuestion(this string message) => message.TrimEnd().EndsWith("?");
	private static bool IsShouting(this string message) => message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
	private static bool IsSilence(this string message) => string.IsNullOrWhiteSpace(message);
    
}