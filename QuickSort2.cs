public static void QuickSort (int[] data, int l, int r)
      {
            // int variables 
         int i, j;
         int x;
 
         i = l;
         j = r;

         x = data [(l + r) / 2]; /* find pivot item */
         while (true) {
            while (data[i] < x)
               i++;
/             while (x < data[j])
               j--;
            if (i <= j) {
               exchange (data, i, j);
               i++;
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
