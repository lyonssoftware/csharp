// c# of swapping two int variables 
public class Swap
{
// main function
   public static void Main()
   {
    // the initial variables
    int a = 5;
    // the second variable 
    int b = 3;
    // the swap variable
    int swap = 0;
    // print the variables
    Console.WriteLine(a);
      // print the original value for b
    Console.WriteLine(b);
      // swap the variables
      // set the intial variable to swap
    swap = a;
      // set the value of a to the current value of b 
    a = b;
    // end the swap
    b = swap;
    // print the new variables
    Console.WriteLine(a);
      // print variable b 
    Console.WriteLine(b);
  }
}      // end of program 
