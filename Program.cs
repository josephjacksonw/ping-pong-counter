using System;
using System.Collections.Generic;

namespace Table
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter how long the ping pong rally is: ");
      int rallySize = Convert.ToInt32(Console.ReadLine());

      for (int x = 1; x <= rallySize; x++)
      if (x % 3 == 0 && x % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (x % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (x % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else 
      {
        Console.WriteLine(x);
      }

    }
  }
}