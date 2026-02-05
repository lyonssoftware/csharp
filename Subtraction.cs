// C# example of Subtraction 
using System;
public class Subtraction
{
// create the main function
   public static void Main()
   {
      // initialize the int a to 5
      int a = 5;
      // initialize the int b to 3
      int b = 3;
      // initialize the int c to 4
      int c = 4;
      // initialize the int d to 7
      int d = 7;
      // initialize the int e to 18
      int e = 18;
      // print the results of 3-5 = -2
      Console.WriteLine(a-b);
      // print the results of 3-5 = -2
      Console.writeline(b-a);
      // print the results of 5 - 4 = 1
      Console.WriteLine(a-c);
      // print the results of 7 - 4 = 3
      Console.WriteLine(d-c);
      // print the results of 5 - 3 - 4 - 7 = -9
      Console.WriteLine(a-b-c-d);
      // print the results of 7 - 4 - 3 - 5 = -5
      Console.WriteLine(d-c-b-a);
      // print the results of 5 + 4 - 3 + 7 = 2 
      Console.WriteLine(a+c-b+d);
      // print the results of ((4 - 7) - (5 - 3)) = -5
      Console.WriteLine((c-d)-(a-b));
   }
}    // end of program
