
Using System;
class UpperLower
{
  static void Main(string[] args)
  {
    // create an array
    Array stringArray = Array.CreateInstance(typeof(String), 6);
    // set the value of the first array
    stringArray.SetValue("Mango", 0);
    // set array
    stringArray.SetValue("Orange", 1);
    // set the value
    stringArray.SetValue("Apple", 2);
            stringArray.SetValue("Grape", 3);
            stringArray.SetValue("Cherry", 4);
    // set valie
            stringArray.SetValue("WaterMelon", 4);
    
    // more code 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // upper bound of the limit 
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // read the last line of the arraylist
            Console.ReadLine();
// print the result 
        }
    } 
