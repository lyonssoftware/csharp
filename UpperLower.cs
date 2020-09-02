// C# convert upper case letters to lower case
Using System;
class UpperLower
{
  static void Main(string[] args)
  {
    // create an array
    Array stringArray = Array.CreateInstance(typeof(String), 6);
    // set the value of the first array element to "Mango"
    stringArray.SetValue("Mango", 0);
    // set a
    stringArray.SetValue("Orange", 1);
    // set the value of the second in 
    stringArray.SetValue("Apple", 2);
            stringArray.SetValue("Grape", 3);
    // set the value of the String Array
            stringArray.SetValue("Cherry", 4);
    // set the value of the array 
            stringArray.SetValue("WaterMelon", 4);
    
  // print the lower bound of the array 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // the upper bound limit of the 
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // read the last line of the arraylist
            Console.ReadLine();
        }
    } // end of program 
