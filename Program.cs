using System;

namespace GenieLamp;

class Program
{
  static void Main(string[] args)
  {
    new RemoteControl().ShowMenu();
  }

  static public int? GetIntegerInput(string prompt)
  {
    int? choice = null;

    Console.Write(prompt);
    string? input = Console.ReadLine();

    if (input != null)
    {
      try
      {
        choice = int.Parse(input);
      }
      catch (FormatException)
      {
        Console.WriteLine(">>> PLEASE PROVIDE NUMBER INPUTS. <<<");
      }
    }

    return choice;
  }
}
