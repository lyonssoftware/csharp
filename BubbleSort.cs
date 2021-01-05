// C# program to iterate the bubblesort method to sort an array 
Using System;
// bubble sort
public class BubbleSort
{     // main function
      public static void main()
      {     // call the bubble sort method 
            BubbleSort();
      }
      public static void BubbleSort (int[] data)
      {
      // int variables to compare
         int i, j;
      // int to hold the lenght of the array 
         int N = data.Length;
         
      // for loop to sort through the array
         for (j=N-1; j>0; j--) {
            // iterate through the next level
            for (i=0; i<j; i++) {
               // check the current value of the  array with the adjacent value of array
               if (data [i] > data [i + 1])
                  // if current is greater than swap the two elements
                  exchange (data, i, i + 1);
            }
         } // end of program
      }
}
