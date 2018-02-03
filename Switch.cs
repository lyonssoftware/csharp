public class Switch
{
   public static void Main()
   {
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
}
