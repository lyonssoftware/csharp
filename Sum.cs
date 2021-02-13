// C# summation of while loop integers
Using System;
class Sum
{
  static void Main(string[] args)
  {
    // initialize the three variables
    int num, sum = 0, r;
    Console.WriteLine("Enter a Number : ");
    // read the int from the user
    
    // parse throught the int 
    num = int.Parse(Console.ReadLine());
    // while loop to iterate through the numbers
    while (num != 0)
    {
      // set r to the remainder of the number 
      r = num % 10;
      // set the new num
      num = num / 10;
      // calculate the new sum
      sum = sum + r;
    }
    // print the line Sum of Digits of the Number : sum
      Console.WriteLine("Sum of Digits of the Number : "+ sum);
    // read the next line of the program
    Console.ReadLine();
    // end
  }
  // end of the program
}
