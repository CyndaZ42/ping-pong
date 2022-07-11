using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number:");
    string inputNumber = Console.ReadLine();
    int parsedInput = int.Parse(inputNumber);
    for (int index = 1; index <= parsedInput; index ++){
      if (index % 5 == 0 && index % 3 == 0) 
      {
        Console.WriteLine("ping-pong");
      }
      
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else 
      {
        Console.WriteLine(index);
      }
    }
  }
}