using System.Collections.Generic;

public class Kata
{
    public static List<int> FindMultiples(int n, int limit)
    {
      List<int> result  = new List<int>();
      for(int i = n ; i<= limit ; i+=n)
            result.Add(i);    
        return result;
    }
}