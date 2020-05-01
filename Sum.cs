// C# summation of while loop integers
Using System;
class Sum
{
  static void Main(string[] args)
  {
    // initialize the variables 
    int num, sum = 0, r;
    Console.WriteLine("Enter a Number : ");
    // read the int
// get info 
    num = int.Parse(Console.ReadLine());
    // while loop
    while (num != 0)
    {
      // set r to the remainder
      r = num % 10;
      // set the new num
      num = num / 10;
      // calculate the new sum
      sum = sum + r;
    }
    // print the sum 
      Console.WriteLine("Sum of Digits of the Number : "+sum);
     
// read the next line Console.ReadLine();
  }
  // end of the program
}
