   public static void BubbleSort (int[] data)
      {
      // int variables to compare
         int i, j;
      // length 
         int N = data.Length;
         
      // for loop to bubble value
         for (j=N-1; j>0; j--) {
            for (i=0; i<j; i++) {
               if (data [i] > data [i + 1])
                  exchange (data, i, i + 1);
            }
         } // end of program
      }
