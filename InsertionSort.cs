Using System;
class InsertionSort
{
    private static void Main(string[] args)
    {
        // array
        int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
        
        // setup the forloop based on the length of the array
        for (int i = 1; i < num.Length; i++)
        {
            // set the key frim the array
            int key = num[i];
            //decrement
            int j = i - 1;
            // while loop
            while (j >= 0 && num[j] > key)
            {
                //loop
                num[j + 1] = num[j];
                j--;
            }
            // set the new key
            num[j + 1] = key;
        }

        //display
        foreach (var item in num)
        {
            // print the current item
            Console.WriteLine(item);
        }
        // display the key
        Console.ReadKey();
    } // end of the program
}
