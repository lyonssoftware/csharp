Using System;
// switch functions
public class Switch
{
   public static void Main()
   {
      // set the condition with int i
    int i = 1;
      // statement is true iterate through the cases
    switch (i)
    {
      case 1:
        Console.WriteLine("One");
          // break
        break;
      case 2:
        Console.WriteLine("Two");
          // print the second line
        Console.WriteLine("Two");
          // break
        break;
          // the last option if this fails  
      default:
          // pront 
        Console.WriteLine("Other");
        break;
      }
   }
}// end of program 
