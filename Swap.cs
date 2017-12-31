public class Swap
{
   public static void Main()
   {
      // variables
    int a = 5;
    int b = 3;
    
    int swap = 0;
    
    Console.WriteLine(a);
    Console.WriteLine(b);
    swap = a;
    a = b;
    b = swap;
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}
