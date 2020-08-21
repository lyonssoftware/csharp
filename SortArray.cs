// c# program to sort an int array
Using System;
public class SortArray
{
// the main program to sort array
   public static void Main()
   {
      // program to sort an integer array; intialize int array
      int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
      // make a second array 
      int[] intArray2 = new int[6] { 8, 10, 2, 6, 3, 1 };
      // sort the integer array object intArray
      Array.Sort(intArray); 
      // use the foreach method to iterate through the array object intArray
      foreach (int i in intArray) 
      {
         // print the output of the array is: 2 3 6 8 10
         Console.Write(i + " "); 
      }
      // end of the program
  }
}
