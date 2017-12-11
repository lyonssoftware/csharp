class ForLoop
{
  int main()
  {
    for(int i = 0; i < 10; i++)
    {
       Console.WriteLine("The is an increment for loop.");
    }
    
    // decrement
    for(int i = 10; i > 0; i--)
    {
      Console.WriteLine("The is a decrement for loop.");
    }
    
    // increment by the 2
    for(int i = 1; i < 10; i*2;
    {
       Console.WriteLine("This for loop increments by 2.");
    }
    // print the line up to 5
    for (int j = 0; j < 5; j++)
    {
      // print the line number 
      Console.WriteLine("This is line " + j);
    }
    // print the line up to 10 
    for (int k = 0; k < 10; k++)
    {
      Console.WriteLine("This is line " + k);
    }
  }
}
