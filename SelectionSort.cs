// C# example of Selection Sort
using System;
class SelectionSort
{
    // main function 
    static void Main(string[] args)
    {
        // set the array size to 10 
        int array_size = 10;
        // initialize the array 
        int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        // initialize the array 2
         int[] array2 = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        // initialize the array 3
         int[] array3 = new int[10] { 10, 50, 205, 39, 10, 67, 80, 78, 90, 30 };
        // initialize the arry 4 
         int[] array4 = new int[10] { 18, 50, 25, 39, 19, 657, 80, 78, 902, 32 };
         // initialize the arry 5
         int[] array5 = new int[10] { 3, 5, 25, 3, 19, 7, 8, 78, 2, 32 };
         // initialize the array 6
         int[] array6 = new int[10] { 33, 25, 245, 13, 89, 73, 83, 18, 32, 82 };
          // initialize the array 7
         int[] array7 = new int[10] { 93, 27, 65, 19, 28, 49, 32, 18, 32, 82 };
        
        // print the below array 
        Console.WriteLine("The Array Before Selection Sort is: ");
        // for loop to iterate through the array
        for (int i = 0; i < array_size; i++)
        {
            // print the array
            Console.WriteLine(array[i]);
        }
        // set the temp value and the min key 
        int tmp, min_key;
         // array to fond selection 
        for (int j = 0; j < array_size - 1; j++)
        {
            // set the min key
            min_key = j;
 
            for (int k = j + 1; k < array_size; k++)
            {
                // check the item of thr array
                if (array[k] < array[min_key])
                {
                    // set the mininum key 
                    min_key = k;
                }
            }
            // set the temporary value
            tmp = array[min_key];
            array[min_key] = array[j];
            // set new temp
            array[j] = tmp;
        }
 
        Console.WriteLine("The Array After Selection Sort is: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
        // print the sorted array
        Console.ReadLine();
    }
    // end of program
}
