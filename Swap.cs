// c# example of swapping two int variables 
public class Swap
{
   // main function of the program
   public static void Main()
   {
    // initialize variable a 
    int a = 5;
    // the second variable 
    int b = 3;
    // the swap variable
    int swap = 0;
    // print the origianl value of variable a
    Console.WriteLine(a);
      //print the origianl value of variable b
    Console.WriteLine(b);
      // set the intial variable to swap
    swap = a;
      // set the value of a to the current value of b 
    a = b;
    // end the swap
    b = swap;
    // print the new a variable
    Console.WriteLine(a);
      // print the new b variable 
    Console.WriteLine(b);
  }
} // end of program 
