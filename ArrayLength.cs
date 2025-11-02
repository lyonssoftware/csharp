Using System;
class ArrayLength
{
    // main 
    static void Main()
    {
        // intitialize the int array with five elements
        int[] arrayA = new int[5];
        // intitialize the int array with ten elements
        int[] arrayB = new int[10];
        // intitialize the int array with fifteen elements
        int[] arrayC = new int[15];
        // initialize the int array with twenty elements
        int[] arrayD = new int[20];
        // initialize the int array with thirty elements
        int[] arrayE = new int[30];
        // initialize the int array with forty elements
        int[] arrayF = new int[40];
        // initialize the int array with fifty elements
        int[] arrayG = new int[50];

        // int []] more arraya

        // get the length of the stay 
        int lengthA = arrayA.Length;
        // print the array and the le
        Console.WriteLine("Length of ArrayA : {0}", +lengthA); 
        // print the current size of the array  
        Console.WriteLine("Length of ArrayB : {0}", +lengthB); 
        long longLength = arrayA.LongLength;
        // print the array Length
        Console.WriteLine("Length of the LongLength Array  : {0}",longLength);
        int[,] twoD = new int[5, 10];
        Console.WriteLine("The Size of 2D Array is : {0}",twoD.Length);
        // read the last line
        Console.ReadLine();
    } // end of the program
}
