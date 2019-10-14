// C# program showing how to use foreach() method
Using System;
public class ForEach2
{
   // main function
   public static void Main()
   {
      // initialize the List 
      var names = new List<string>() { "John", "Tom", "Peter" };
      // iterate through the names 
      foreach (string name in names)
      {
       // print the name from the array list 
        Console.WriteLine(name);
      }
  } // end of the program
}
