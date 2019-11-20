using System;


public static class HelloWorld
{
    public static string Hello(string name)
    {
        if (name != null)
            return $"Hello, {name}";
        else
            return "Hello, World!";
    }
    static void Main(string[] args)
    {
        Hello();
    }
}
