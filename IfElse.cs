Using System;

/*
  Program to test if else statements
*/
public class IfElse
  {
    static void Main(string[] args)
    {
      // program to demo the if else statement
      // variables 
      int a = 5, b = 5, c = 10;

      // if a is equal to b 
      if (a == b)
        // print the a variable
        Console.WriteLine(a);
      // or statement 
      if ((a > c) || (a == b))
        Console.WriteLine(b);
       // and comparison
      if ((a >= c) && (b <= c))
        // more info
        // print c
        Console.WriteLine(c);
    }
  }
// end of the program
}
