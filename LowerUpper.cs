// C# convert lower case leters to uppercase letters
Using System;
class LowerUpper
{
  static void Main(string[] args)
  {
    // create a new Array object and set the size to 6 
    Array stringArray = Array.CreateInstance(typeof(String), 6);
    // insert "Mango" into the first array
    stringArray.SetValue("Mango", 0);
    /// insert
    stringArray.SetValue("Orange", 1);
    // insert into the array 
    stringArray.SetValue("Apple", 2);
    // set the value
            stringArray.SetValue("Grape", 3);
    // set value thr value to cherry
            stringArray.SetValue("Cherry", 4);
    // ser value 
            stringArray.SetValue("WaterMelon", 4);
    //print the lower bound
// the lower 
// print 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // upper bounds
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // read the last line
    // read line the line and get the data
            Console.ReadLine();
        }
    } // end of program
}
