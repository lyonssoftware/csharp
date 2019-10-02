// how to inplement insertion sort in  C#
Using System;
class InsertionSort
{
// main function
    private static void Main(string[] args)
    {
        // this is the unsorted array [69,56,77,44,8,0,111,566
        int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
 
        // setup the forloop based on the length of the array
        for (int i = 1; i < num.Length; i++)
        {
            // create new key from selected item in array
            int key = num[i];
            //decrement
            int j = i - 1;
            // while loop
            while (j >= 0 && num[j] > key)
            {
                //loop
                num[j + 1] = num[j];
                // iterate
                j--;
            }
            // set the new key
            num[j + 1] = key;
// end 
        }

        //display
        foreach (var item in num)
        {
            // print the current item
            Console.WriteLine(item);
            // finish writing
        }
        // print the key of the array
        Console.ReadKey();
    } // end of the program
}
