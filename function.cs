class Function
{
  void Foo()
  {
    Console.System.print("this is the function foo");
  }
  
  void Bar()
  {
    Console.System.print("this is the function bar");
  }
  
  void Add(int x, int y)
  {
    // this functons adds two numbers
    int sum = x + y;
    Console.System.print(sum);
  }
  
  void Subtract(int x, int y)
  {
    // this functons subtracts two numbers
    int differece = x - y;
    Console.System.print(difference);
  }

  public void main()
  {
    // this is the funciton 
    Foo();
    Bar();
    Add();
    Subtract();
  }
}
