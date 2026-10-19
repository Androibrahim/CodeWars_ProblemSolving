using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
        List<int> result = new List<int>();
        if (xs[0] == 0 )
          result.Add(xs[0]);
        for (int i = 1; i < xs.Count; i++)
            if (xs[i] % i == 0)
                result.Add(xs[i]);
        return result;
    
  }
}