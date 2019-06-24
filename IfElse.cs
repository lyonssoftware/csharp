Using System;
/*
  Program to test if else statements
*/
public class IfElse
  {
    static void Main(string[] args)
    {
      // program to demo the if else statement
      // intialize variables a, b, and c
      int a = 5, b = 5, c = 10;

      // if a is equal to b then print equal
      if (a == b)
        // print the a variable
        Console.WriteLine(a);
      // or statement 
      if ((a > c) || (a == b))
        Console.WriteLine(b);
       // and comparison
      if ((a >= c) && (b <= c))
        // is a is greater and b is smaller than c
        Console.WriteLine(c);
      // end of program
    }
  }
// end of the program
}
