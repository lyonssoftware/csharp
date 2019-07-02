// program to bubble sort an array   
import System;
public BubbleSort
{
      public static void BubbleSort (int[] data)
      {
      // int variables to compare
         int i, j;
      // length 
         int N = data.Length;
         
      // for loop to bubble value
         for (j=N-1; j>0; j--) {
               // iterate through the loop
            for (i=0; i<j; i++) {
               if (data [i] > data [i + 1])
                     // if thr adjacebt is greater than current, swap 
                  exchange (data, i, i + 1);
            }
         } // end of program
      }
}
