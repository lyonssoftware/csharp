// C# program using ForEach to intertate through ArrayList
class ForEach
{
  // main function
  static void Main(string[] args)
  {            
    // create instance of array list
    ArrayList list = new ArrayList();
    // add the first name to the array list
    list.Add("John Doe");
    // add a new name to array list
    list.Add("Jane Doe");
    // add the name "Someone Else" to the ArrayList
    list.Add("Someone Else");
    // for loop
    foreach(string name in list)
    {
      // print the name
      Console.WriteLine(name)
        // end 
    }
    Console.ReadLine();
  }
  // end of the program
