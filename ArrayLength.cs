Using System;
class ArrayLength
{
    // main 
    static void Main()
    {
        // intitialize the int array with five slots
        int[] arrayA = new int[5];
        // get the length of the stay 
        int lengthA = arrayA.Length;
        // print the array and the length
        Console.WriteLine("Length of ArrayA : {0}", +lengthA); 
        // new 
        // set the array length 
        long longLength = arrayA.LongLength;
        // print the array Length
        Console.WriteLine("Length of the LongLength Array  : {0}",longLength);
        
        int[,] twoD = new int[5, 10];
        Console.WriteLine("The Size of 2D Array is : {0}",twoD.Length);
        // read the last line
        Console.ReadLine();
    } // end of the program
}
