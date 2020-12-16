// example of a C# functions 
class Function
{
  // this is a sample function named Foo();
  // the function foo prints the statement "this is the function foo"
  void Foo()
  {
    // print the statement
    Console.System.print("this is the function foo");
  }
  // bar function 
  void Bar()
  {
    // print the statement "This is the function bar"
    Console.System.print("this is the function bar");
  }
  // add function 
  // it adds two integers together
  void Add(int x, int y)
  {
    // this functons adds two numbers
    int sum = x + y;
    Console.System.print(sum);
  }
  // subtract function
  void Subtract(int x, int y)
  {
    // this functons subtracts two numbers
    int differece = x - y;
    // print the difference
    Console.System.print(difference);
  }
  // divide function with two int parameters 
  void Divide(int x, int y)
  {
// print the results of x divided by y 
    Console.System.print(x/y)
  }
  // print the result of x multiplied by y 
  void Multiply(int x, int y)
  {
// print the results x and y 
    Console.System.print(x*y)
  }
  
  // return type 
  int Add(int x, int y)
  {
// set the sum of the two ints 
    int sum = x + y;
    // returnt the sum
    return sum;
  }
  // return an int value
  int Subtraction(int x, int y)
  {
    // get difference
    int difference = x - y;
    return difference;
  }

  // this is the main function 
// main is always public
  
  public void main()
  {
    // variables 
    int x = 5, int y = 7;
    // this is the function 
    Foo();
    // call the function Bar
    Bar();
    // function with parameters
    Addition(x,y);
    // call the Subtract function
    Subtract(x,y);
    // call the Divide method
    Divide(x,y);
    Multiply(x,y);
    // call the add method
    Add(x, y);
    Subtraction(x,y);
    Add(3,8);
    Subtraction(9,7);
    // more functions
    Divide(7,5);
  }
  // end of the program
}
