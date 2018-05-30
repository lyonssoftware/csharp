Using System;
class InsertionSort
{
    private static void Main(string[] args)
    {
        int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
        for (int i = 1; i < num.Length; i++)
        {
            int key = num[i];
            int j = i - 1;
            while (j >= 0 && num[j] > key)
            {
                //loop
                num[j + 1] = num[j];
                j--;
            }
            num[j + 1] = key;
        }

        //display
        foreach (var item in num)
        {
            // 0"print 
            Console.WriteLine(item);
        }
        // display the key
        Console.ReadKey();
    } // end of program
}
