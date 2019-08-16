// use selection sort to sort an array
using System;
class SelectionSort
{
    static void Main(string[] args)
    {
        // set the array size
        int array_size = 10;
        // create new array from array size
        int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        // print the insortef arrsy 
Console.WriteLine("The Array Before Selection Sort is: ");
        for (int i = 0; i < array_size; i++)
        {
            // print the array
            Console.WriteLine(array[i]);
        }
        int tmp, min_key;
 // for loop 
        for (int j = 0; j < array_size - 1; j++)
        {
// set the new minimum key
            min_key = j;
 // for loop to iterate
            for (int k = j + 1; k < array_size; k++)
            {
                // if correct 
                if (array[k] < array[min_key])
                {
                    // set the minimum key
                    min_key = k;
                }
            }
 
            tmp = array[min_key];
// set the libk
            array[min_key] = array[j];
// set the temp
            array[j] = tmp;
        }
 
        Console.WriteLine("The Array After Selection Sort is: ");
//for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.ReadLine();
    }
} // end of the program
