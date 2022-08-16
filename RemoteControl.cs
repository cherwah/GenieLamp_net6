using System;

namespace GenieLamp;

class RemoteControl
{
  private Lamp lamp;

  public RemoteControl()
  {
    lamp = new Lamp();
  }

  public void ShowMenu()
  {
    while (true)
    {
      string prompt = "\n\n1. TURN ON THE LIGHT\n" +
        "2. TURN OFF THE LIGHT\n" +
        "3. WHAT IS THE COLOR of the LIGHT?\n" +
        "4. IS THE LAMP ON?\n" +
        "\nPLEASE CHOOSE ONE: ";

      int? choice = GetInput(prompt);

      if (choice != null)
      {
        if (choice >= 1 && choice <= 4)
        {
          OnMenuSelect((int)choice);
        }
        else
        {
          Console.WriteLine(">>> INVALID CHOICE. <<<");
        }
      }
    }
  }

  public int? GetInput(string prompt)
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

  protected void TurnOnLamp()
  {
    if (! lamp.IsOn())
    {
      lamp.LightOn();
      Console.WriteLine("\n>>> THE LIGHT IS ON NOW <<<");
    }
    else
    {
      Console.WriteLine("\n>>> THE LIGHT IS ALREADY ON <<<");
    }
  }

  protected void TurnOffLamp()
  {           
    if (lamp.IsOn())
    {
      lamp.LightOff();
      Console.WriteLine("\n>>> THE LIGHT IS OFF NOW <<<");
    }
    else
    {
      Console.WriteLine("\n>>> THE LIGHT IS ALREADY OFF <<<");
    }
  }

  protected void GetLampCurrentColor()
  {    
    if (lamp.IsOn())
    {
      Console.WriteLine("\n>>> THE COLOR IS " + lamp.GetCurrColor() + " <<<");
    }
    else
    {
      Console.WriteLine("\n>>> THE LIGHT IS NOT ON <<<");
    }
  }

  protected void IsLampOn()
  {
    Console.WriteLine("\n>>> THE LAMP IS " + 
      (lamp.IsOn() ? "ON" : "OFF") + " <<<");
  }

  protected void OnMenuSelect(int choice)
  {
    switch (choice)
    {
      case 1:
        TurnOnLamp();
        break;

      case 2:
        TurnOffLamp();
        break;

      case 3:
        GetLampCurrentColor();
        break;

      case 4:
        IsLampOn();
        break;
    }
  }
}
