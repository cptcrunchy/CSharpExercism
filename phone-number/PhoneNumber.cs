using System;
using System.Linq;

namespace PhoneNumber
{
    public static class PhoneNumber
    {
        public static string Clean(string phoneNumber) 
        {

            var cleanDigits = phoneNumber.SanitizePhone();

            if(cleanDigits.Length != 10 || cleanDigits[0] < 2 || cleanDigits[3] < 2) throw new ArgumentException("Invalid Phone Number");

            return cleanDigits.Aggregate("", (a, b) => a + b);
        }
        private static int[] SanitizePhone(this string phoneNumber) => phoneNumber
            .ToCharArray()
            .Where(n => char.IsDigit(n))
            .Select(c => int.Parse(c.ToString()))
            .SkipWhile(c => c == 1).ToArray();
    
    }

}