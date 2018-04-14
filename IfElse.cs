Using System;

public class IfElse
  {
    static void Main(string[] args)
    {
      // program to demo the if else statement
      // variables 
      int a = 5, b = 5, c = 10;

      // if a is equal to b 
      if (a == b)
        Console.WriteLine(a);
// or statement 
      if ((a > c) || (a == b))
        Console.WriteLine(b);

      if ((a >= c) && (b <= c))
        Console.WriteLine(c);
    }
  }
// end of the program
}
