// implementing Binary Triangle in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class BinaryTriangle
    {
 // main function
        public static void Main(String[] args)
        {
         // int variables
            int p, lastInt = 0, input;
         // get the number of rows
            Console.WriteLine("Enter the Number of Rows : ");
          // get the input fo the integer
            input = int.Parse(Console.ReadLine());
            // for loop to iterate through loop
            for (int i = 1; i <= input; i++)
            {
                // for loop to iterate
                for (p = 1; p <= i; p++)
                {
                 // if you are at the last int  
                    if (lastInt == 1)
                    {
                     // print the current 
                        Console.Write("0");
                     // set the int
                        lastInt = 0;
                    }
                 // find the last int
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                } Console.Write("\n");
            }
            Console.ReadLine();
        } 
    } // end of program 
