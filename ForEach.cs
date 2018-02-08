class ForEach
{
  static void Main(string[] args)
  {            
    ArrayList list = new ArrayList();
    list.Add("John Doe");
    list.Add("Jane Doe");
    list.Add("Someone Else");
            
    foreach(string name in list)
    {
      Console.WriteLine(name);
    }
    Console.ReadLine();
  }
}
