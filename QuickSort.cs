// example of Quicksort in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
// quicksort namespace
namespace Quicksort
{
   // class name
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            string[] unsorted = { "z","e","x","c","m","q","a"};
            
            // create an unsoted array
            string[] unsorted2 = { "j","m","k","i","m","u","z"};
         
            // create an unsoted array
            string[] unsorted3 = { "q","j","k","o","m","u","n"};
 
            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
            // print the unsorted array
                Console.Write(unsorted[i] + " ");
            }
            // print out the array 
            Console.WriteLine();

            // Sort the array using quicksort
            Quicksort(unsorted, 0, unsorted.Length - 1);
 
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
             // print the unsorted
                Console.Write(unsorted[i] + " ");
            }
 // print the insorted list 
            Console.WriteLine();
 // read in the new array 
            Console.ReadLine();
        }
        // Quicksort method
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
// initialed rhe set 
            int i = left, j = right;
// set the pivot 
            IComparable pivot = elements[(left + right) / 2];
 
         
            // while the elements are in
            while (i <= j)
            {   // while loop to compare two elements in the array
                while (elements[i].CompareTo(pivot) < 0)
                {
                 // increment by 1
                    i++;
                }
                // check the the element in the array then pivot
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
 // compare if the current 
                if (i <= j)
                {
                    // Swa
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
 
                    i++;
                    j--;
                }
            }
 
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
 
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
 
    }
}
