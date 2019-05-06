public static void QuickSort (int[] data, int l, int r)
      {
            // int variables 
         int i, j;
// integer
         int x;
 
         i = l;
         j = r;

         x = data [(l + r) / 2]; /* find pivot item */
      
      // while unsorted begin the sort
         while (true) {
// while the current is less than the adjacent int
            while (data[i] < x)
               i++;
/             while (x < data[j])
               j--;
            if (i <= j) {
                  //swap
               exchange (data, i, j);
               i++;
               j--;
            }
            if (i > j)
               break;
         }
         if (l < j)
               // qicksort
            IntArrayQuickSort (data, l, j);
         if (i < r)
            IntArrayQuickSort (data, i, r);
      }

      public static void IntArrayQuickSort (int[] data)
      {
         IntArrayQuickSort (data, 0, data.Length - 1);
      }
