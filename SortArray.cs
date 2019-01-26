Using System;
public class SortArray
{
   public static void Main()
   {
      // program to sort an integer array; intialize int array
      int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
      // sort the array
      Array.Sort(intArray);
      // use the foreach method to iterate through the array
      foreach (int i in intArray) 
      {
         // print this output for the array
         // output: 2 3 6 8 10
         Console.Write(i + " "); 
      }
      // end of the program
  }
}
