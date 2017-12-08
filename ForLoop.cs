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
    // print the line 
    for (int j = 0; j < 5; j++)
    {
      Console.WriteLine("This is line " + j);
    }
  }
}
