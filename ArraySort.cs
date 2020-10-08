// Example of array sort in C#
using System;
class ArraySort
{
    static void Main()
    {
        //create an array of 5 strings for colors
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
        // iterate through the colors array and print each one on seperate lines
        foreach (string color in colors)
        {
            // print the the colors as string
            Console.WriteLine(color);
        }
    } // end of program 
}
