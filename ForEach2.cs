// C# program showing how to use foreach() method
Using System;
public class ForEach2
{
   // main function
   public static void Main()
   {
      // initialize the List 
      var names = new List<string>() { "John", "Tom", "Peter" };
      
       // initialize the second List 
      var names2 = new List<string>() { "Laura", "Tanya", "Petra" };
      // use foreach() to iterate through the names 
      foreach (string name in names)
      {
       // print the name from the the List of strings
        Console.WriteLine(name);
      }
  } // end of the program
}
