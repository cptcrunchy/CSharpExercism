using System;
public static class CollatzConjecture
{
    public static int Steps(int number = 0)
    {
        if (number < 1) throw new ArgumentException("Number must be greater than 1");
        if (number == 1) return number;
        return number % 2 == 0 ? 1 + Steps(number / 2) : 1 + Steps(number * 3 + 1);
    }
}
