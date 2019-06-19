// program to iterate through names
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
    // add the name "Sometone Else"
    list.Add("Someone Else");
    // begin fge forkoop
            
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
