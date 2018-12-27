public class Switch
{
   public static void Main()
   {
      // set the condition with int i
    int i = 1;
    switch (i)
    {
      case 1:
        Console.WriteLine("One");
        break;
      case 2:
        Console.WriteLine("Two");
        Console.WriteLine("Two");
        break;
      default:
        Console.WriteLine("Other");
        break;
      }
   }
}// end of program 
