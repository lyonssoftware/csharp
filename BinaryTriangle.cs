using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
class BinaryTriangle
    {
 // main function
        public static void Main(String[] args)
        {
         // variables
            int p, lastInt = 0, input;
         // get the number of rows
            Console.WriteLine("Enter the Number of Rows : ");
          // get the input fo the integer
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                     // print item
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
