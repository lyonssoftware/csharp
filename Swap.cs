public class Swap
{
   public static void Main()
   {
    // the initial variables
    int a = 5;
    int b = 3;
    // the swap variable
    int swap = 0;
    // print vriabls
    Console.WriteLine(a);
    Console.WriteLine(b);
      // swap the variables
    swap = a;
    a = b;
    b = swap;
    // print the new variables
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}
