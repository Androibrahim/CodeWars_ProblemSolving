public class Kata
{
  public static string Well(string[] x)
  {
    int counter =0;
    for(int i=0 ; i<x.Length; i++)
        if(x[i] == "good") counter++;
          
    return counter > 2 ? "I smell a series!" : (counter == 1 ||counter == 2)  ? "Publish!" : "Fail!";
  }
}