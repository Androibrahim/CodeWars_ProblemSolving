using System.Linq;
public class Kata
{
  public static string Remove(string s)
  {
    return s.Last() == '!' ? s.Remove(s.Length - 1) : s;
  }
}