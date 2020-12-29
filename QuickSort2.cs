// program to implement Quicksort in C#
Using System;
class QuickSort
{
      // main function
      public static void QuickSort (int[] data, int l, int r)
      {
         // intialize int variables 
         int i, j;
          // int x variable 
         int x;
          // initialize int i and set it the new value
         i = l;
         // set j value to r
         j = r;
         int k = 0;
         // create the pivot point 
         x = data [(l + r) / 2]; /* find pivot item */
      
      // while unsorted begin the sort
         while (true) {
               // check if current elemnt is less thab thr int
            while (data[i] < x)
               i++;
               // while loop to iterate through the array
             while (x < data[j])
            // decrement j by 1
               j--;
            if (i <= j) {
                  //swap
               exchange (data, i, j);
                  // increment i 
               i++;
                  // decrement j
               j--;
            }
// if statement to check is to break 
            if (i > j)
                  // break the system if the left is larger than rigth
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
