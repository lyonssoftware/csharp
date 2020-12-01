// C# convert lower case leters to uppercase letters
Using System;
class LowerUpper
{
  // main method
  static void Main(string[] args)
  {
    // create a new Array object and set the size to 6 
    Array stringArray = Array.CreateInstance(typeof(String), 8);
    // insert the string "Mango" into the first index of array
    stringArray.SetValue("Mango", 0);
    // insert the string "Orange" into the second index of array
    stringArray.SetValue("Orange", 1);
     // insert the string "Apple" into the third index of array
    stringArray.SetValue("Apple", 2);
    // set the value to grape
    stringArray.SetValue("Grape", 3);
    // set the string to cherry 
            stringArray.SetValue("Cherry", 4);
    // set the value 
          stringArray.SetValue("Blackberry", 5);
    // set the value 
            stringArray.SetValue("WaterMelon", 6);
    
    // set the value 
        stringArray.SetValue("Passion Fruit", 7);
    //print "the lower" 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // the upper bounds of the array
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // read line the line and get the data
            Console.ReadLine();
        }
    } // end of program
}
