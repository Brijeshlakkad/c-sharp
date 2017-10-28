using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        List<string> food = new List<string>();
        food.Add("apple");
        food.Add("banana");
        
        List<string> vegetables = new List<string>();
        vegetables.Add("tomato");
        vegetables.Add("carrot");
        
        food.AddRange(vegetables);
        Console.WriteLine(food.Count);
        

    }
}