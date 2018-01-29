public class SortArray
{
   public static void Main()
   {
      // sort int array
      int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
      Array.Sort(intArray);
      // write array
      foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10  
      // end of the program
  }
}
