using System;

public class Kata
{
  public static string BatteryBars(int percent)
  {   
        switch(percent)
        {

            case int n when n == 100: return "[#####]";
            case int n when n >= 80:  return "[####.]";
            case int n when n >= 60:  return "[###..]";
            case int n when n >= 40:  return "[##...]";
            case int n when n >= 20:  return "[#....]";
            default:                  return "[.....]";
        }
  }
}