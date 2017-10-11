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
  
  void Divide(int x, int y)
  {
    Console.System.print(x/y)
  }

  public void main()
  {
    int x = 5, int y = 7;
    // this is the funciton 
    Foo();
    Bar();
    Add(x,y);
    Subtract(x,y);
    Divide(x,y);
  }
}
