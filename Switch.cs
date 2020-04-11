// using switch in C#
Using System;
public class Switch
{
   // main function of the switch function 
   public static void Main()
   {
      // set the condition with int i
    int i = 1;
      // statement is true iterate through the cases
    switch (i)
    {
      // first case
      case 1:
          // print the statement "One"
        Console.WriteLine("One");
          // break
        break;
// second case
      case 2:
          // print "Two"
        Console.WriteLine("Two");
          // print the second line
        Console.WriteLine("Two");
          // break
        break;
          // the last choice of the others don’t work 
      default:
          // print line "other"
        Console.WriteLine("Other");
        break;
      }
   }
}// end of program 
