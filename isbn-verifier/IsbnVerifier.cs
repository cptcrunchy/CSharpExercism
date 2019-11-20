using System;
using System.Linq;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        int[] filteredISBN = number
            .Where(c => char.IsDigit(c) || c == 'X')
            .Select(c => c == 'X' ? 10 : int.Parse(c.ToString()))
            .ToArray();

        bool isbnValid;

        if (filteredISBN.Length != 10){
            isbnValid = false;
        }                                       
        else
        {
            int x = 0;
            for(int i = 0; i < 10; i++){
                if(i != 9 && filteredISBN[i] == 10) return false;
                x += filteredISBN[i] * (10-i);
            }
        
            isbnValid = x % 11 == 0;
        }
        return isbnValid;
    }
}