// program to implement Quicksort in C#
Using System;
class QuickSort
{
      public static void QuickSort (int[] data, int l, int r)
      {
         // int variables 
         int i, j;
          // int
         int x;
 // initialize int i 
         i = l;
// set j value to r
         j = r;
            // int k = 0;
//  ser
         x = data [(l + r) / 2]; /* find pivot item */
      
      // while unsorted begin the sort
         while (true) {
               // check if current elemnt is less thab thr int
            while (data[i] < x)
               i++;
               // while loop
/             while (x < data[j])
               j--;
            if (i <= j) {
                  //swap
               exchange (data, i, j);
                  // increment i 
               i++;
                  // decrement j
               j--;
            }
            if (i > j)
               break;
         }
         if (l < j)
            IntArrayQuickSort (data, l, j);
         if (i < r)
            IntArrayQuickSort (data, i, r);
      }

      public static void IntArrayQuickSort (int[] data)
      {
         IntArrayQuickSort (data, 0, data.Length - 1);
      }
}
