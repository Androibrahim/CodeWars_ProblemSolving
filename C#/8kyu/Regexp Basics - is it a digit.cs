using System;
using System.Text;
using System.Linq;

public static class Kata
{
  public static bool Digit(this string s) => s.Length == 1 ? s.All(s => s >= 48 && s <= 57) : false;
}