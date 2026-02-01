/*
 * C# Program to Check whether the Entered Number is Even or Odd
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace check1
{
    class EvenOdd
    {
// main function
        static void Main(string[] args)
        {
            // initialize the int i = 0;
            int i = 0;
            // initialize the int j to -1
            int j = -1;
            // initialize the int z to 10
            int z = 10;
            // read the first int 
            Console.Write("Enter a Number : ");
            // get the number from user
            i = int.Parse(Console.ReadLine());
            // check if int is even or odd
            if (i % 2 == 0)
            {
               // enter the number
               Console.Write("Entered Number is an Even Number");
               // read in value
               Console.Read();
            }
// else statement 
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
