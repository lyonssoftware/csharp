using System;
class ArraySort
{
    static void Main()
    {
        // array of strings for colors
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
        // iterate through the colors array
        foreach (string color in colors)
        {
            // print the string 
            Console.WriteLine(color);
        }
    } // end of program 
}
