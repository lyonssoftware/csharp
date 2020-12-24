// C# convert upper case letters to lower case
Using System;
class UpperLower
{
  static void Main(string[] args)
  {
    // create an array
    Array stringArray = Array.CreateInstance(typeof(String), 7);
    // set the value of the first array to "Mango"
    stringArray.SetValue("Mango", 0);
    // set array of the second item 
    stringArray.SetValue("Orange", 1);
    // set the value
    stringArray.SetValue("Apple", 2);
    // set the value of the 
    stringArray.SetValue("Grape", 3);
    // set the value of the String Array
    stringArray.SetValue("Cherry", 4);
    // set value of the array 
    stringArray.SetValue("Black Berry", 5);
    // set value of the array 
    stringArray.SetValue("Banana", 6);
    
    
  // print the lower bound of the array 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // upper bound when it hits limit
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // read the last line of the arraylist
            Console.ReadLine();
        }
 } // end of program 
