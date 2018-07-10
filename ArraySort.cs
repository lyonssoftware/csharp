using System;
class ArraySort
{
    static void Main()
    {
        // array of strings
        string[] colors = new string[]
        {
            "orange",
            "blue",
            "yellow",
            "aqua",
            "red"
        };
        // Call Array.Sort method.
        Array.Sort(colors);
        foreach (string color in colors)
        {
            // print the string 
            Console.WriteLine(color);
        }
    } // end of program 
}
