Using System;
class UpperLower
{
  static void Main(string[] args)
  {
    // create an array
    Array stringArray = Array.CreateInstance(typeof(String), 6);
    stringArray.SetValue("Mango", 0);
    //set the value
    stringArray.SetValue("Orange", 1);
    stringArray.SetValue("Apple", 2);
    // set the value
            stringArray.SetValue("Grape", 3);
            stringArray.SetValue("Cherry", 4);
    // set watermelon
            stringArray.SetValue("WaterMelon", 4);
    
    // more code 
            Console.WriteLine("The Lower Bound of the Array : {0}",stringArray.GetLowerBound(0).ToString());
    // upper bound 
            Console.WriteLine("The Upper Bound of the Array : {0}",stringArray.GetUpperBound(0).ToString());
    // tead the array 
            Console.ReadLine();
        }
    } // end of the program 
