// C# example of recursion
using System;
class Recursion
{
    public static void Main()
{
        // intialize variables 
    int num, result;
        // createnew object
    pro pg = new pro();
// entre the number
    Console.WriteLine("Enter the Number : ");
    num=int.Parse(Console.ReadLine());
        // result 
    result =pg.sum(num);
        // print
    Console.WriteLine("Sum of Digits in {0} is {1}", num, // read line

Console.ReadLine();
}
}
class pro
{
    public int sum(int num)
    {
        if (num != 0)
        {
            // iterate through shd gey rhe remainder
            return (num % 10 + sum(num / 10));
        }
        else
        {
            //whenndone tetuen 0
            return 0;
            //return if invalid
        }
    }// end of the program
}
