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
// initialize int 
            int i;
            Console.Write("Enter a Number : ");
// set the input
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
     // read in value            
Console.Read();
            }
// else statement 
            else
            {
// print
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
// end of program 
