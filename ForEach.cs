class ForEach
{
  static void Main(string[] args)
  {            
    // create instance of array list
    ArrayList list = new ArrayList();
    list.Add("John Doe");
    // add a new name to array list
    list.Add("Jane Doe");
    //addnae 
    list.Add("Someone Else");
            
    // for loop
    foreach(string name in list)
    {
      // print the name
      Console.WriteLine(name);
    }
    Console.ReadLine();
  }
  // end of the program
