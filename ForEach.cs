class ForEach
{
  static void Main(string[] args)
  {        
    // arraylist instance 
    ArrayList list = new ArrayList();
    list.Add("John Doe");
    list.Add("Jane Doe");
    list.Add("Someone Else");
            
    foreach(string name in list)
    {
      // print the line 
      Console.WriteLine(name);
    }
    // read it 
    // thr output 
    Console.ReadLine();
  }
  // end of the program
}
