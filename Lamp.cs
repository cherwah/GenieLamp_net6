using System;

namespace GenieLamp;

public class Lamp
{
  private int curr_color;
  private bool is_on;
  private string[] colors = { "RED", "GREEN", "BLUE" };

  public Lamp()
  {
    is_on = false;   // not ON at the start
    curr_color = -1; // points to no color at the start
  }

  public void LightOff()
  {
    is_on = false;
  }

  public void LightOn()
  {
    // uses the modulo-operator (%) to keep the color index 
    // to be always within 0 and 2.
    curr_color = (curr_color + 1) % colors.Length;
    is_on = true;
  }

  public string GetCurrColor()
  {
    return colors[curr_color];
  }

  public bool IsOn()
  {
    return is_on;
  }
}
