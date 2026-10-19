public class Kata
{
  public static bool CorrectTail(string body, string tail)
  {
        string sub = body.Substring(body.Length - (tail.Length));

        if (sub == tail)
            return true;
        else
            return false;
  }
}