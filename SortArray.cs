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
      int[] intArray2 = new int[6] { 6, 9, 2, 6, 5, 10 };
      // 
      int[] intArray3 = new int[6] { 18, 10, 1, 6, 8, 11 };
      // 
      int[] intArray4 = new int[6] { 1, 20, 15, 6, 8, 18 };
      
       int[] intArray5 = new int[6] { 7, 8, 9, 6, 13, 1 };
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
