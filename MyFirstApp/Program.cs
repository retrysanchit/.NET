using System;

namespace MyFirstApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello " + args[0] + " Boss"); // -- for arg in CLI

      foreach (var arg in args)
      {
        Console.WriteLine(arg);
      }

      if (args.Length >= 2)
      {
        string name = args[0];
        string age = args[1];

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"age: {age}");
      } else
      {
        Console.WriteLine($"Usage: MyApp <name> <age>"); // san try Sanchit 20
      }
    }
  }
}