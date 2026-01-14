Using System;
class ArrayLength
{
    // main 
    static void Main()
    {
        // intitialize the int array with 5 elements
        int[] arrayA = new int[5];
        // intitialize the int array with 10 elements
        int[] arrayB = new int[10];
        // intitialize the int array with 15 elements
        int[] arrayC = new int[15];
        // initialize the int array with 20 elements
        int[] arrayD = new int[20];
        // initialize the int array with 30 elements
        int[] arrayE = new int[30];
        // initialize the int array with 40 elements
        int[] arrayF = new int[40];
        // initialize the int array with 50 elements
        int[] arrayG = new int[50];
        // initialize the int array with 60 elements
        int[] arrayH = new int[60];
        // initialize the int array with 70 elements
        int[] arrayI = new int[70];
         // initialize the int array with 80 elements
        int[] arrayJ = new int[80];
        // initialize the int array with 90 elements
        int[] arrayK = new int[90];
        // initialize the int array with 100 elements
        int[] arrayL = new int[100];
        // initialize the int array with 100 elements
        int[] arrayM = new int[100];

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
