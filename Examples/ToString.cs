using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        int integer = 1;
        string ourString = "Something to be replaced by an int";
        ourString = integer.ToString();
        System.Console.WriteLine(ourString);
        

    }
}
