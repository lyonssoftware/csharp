// C# program showing how to use foreach() method
Using System;
public class ForEach2
{
   // main function of the program 
   public static void Main()
   {
      // initialize the List with 3 names
      var names = new List<string>() { "John", "Tom", "Peter" };
       // initialize the second List 
      var names2 = new List<string>() { "Laura", "Sam", "Greg" };
      // use foreach() to iterate through the names

 var names3 = new List<string>() { "Laura", "Sam", "Greg" };
      foreach (string name in names)
      {
       // print the name from the the List of strings
        Console.WriteLine(name);
      }
  } // end of the program
}
