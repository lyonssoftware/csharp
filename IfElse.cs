/*
  Program to demo the if else statement in C#
*/
Using System;
public class IfElse
  {
    // main function
    static void Main(string[] args)
    {
      // intialize variables a, b, and c to 5, 5 and 10 
      int a = 5, b = 5, c = 10;
      
      int d = 8, e = 3, f = 11;
      
      int g = 11, h = 6, i = 15;
      
      

      // if a is equal to b then print equal
      if (a == b)
        // print the a variable
        Console.WriteLine(a);
      // if a is greater than c or a is equal to b 
      if ((a > c) || (a == b))
        // print the b integer
        Console.WriteLine(b);
// check it
      // if statement 
      if ((a >= c) && (b <= c))
        // is a is greater and b is smaller than c
        Console.WriteLine(c);
      // end of program
    }
  }
// end of the program
}
