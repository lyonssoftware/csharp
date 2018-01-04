public class Swap
{
   public static void Main()
   {
      // variables
    int a = 5;
    int b = 3;
    // swap variable
    int swap = 0;
    // print vriabls
    Console.WriteLine(a);
    Console.WriteLine(b);
      // swap
    swap = a;
    a = b;
    b = swap;
      // print the new numbers
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}
