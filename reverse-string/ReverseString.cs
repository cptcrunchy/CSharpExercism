using System.Linq;


public static class ReverseString
{

  public static string Reverse(string input) => (input.Length <= 0) ? input : new string(input.ToCharArray().Reverse().ToArray());
 
}
