// how to inplement insertion sort in  C#
Using System;
class InsertionSort
{
// main function
    private static void Main(string[] args)
    {
        // this is the unsorted array [69,56,77,44,8,0,111,566
        int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
        
        // this is the unsorted array [69,56,77,44,8,0,111,566
        int[] num2 = { 69, 56, 77, 44, 8, 0, 111, 566 };
        
         // this is the unsorted array [69,56,77,44,8,0,111,566
        int[] num3 = { 69, 56, 77, 44, 8, 0, 111, 566 };
        
        
        
        // setup the forloop based on the length of the array
        for (int i = 1; i < num.Length; i++)
        {
            // create new key from selected item in array
            int key = num[i];
            //initialize the j variable and set to the array list minus 1
            int j = i - 1;
            // while loop to iterate through the key 
            while (j >= 0 && num[j] > key)
            {
                // while in the loop update the key 
                num[j + 1] = num[j];
                // Decrement j by 1
                j--;
            }
            // set the new key to the new value 
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
