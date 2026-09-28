using System ; 
using System.Collections.Generic;
public class Kata
{
  public static int[] GenerateRange(int min, int max, int step)
  {
//       List<int> range = new List<int>();
//       for (int i = min; i <= max; i += step) 
//         range.Add(i);
//       return range.ToArray(); 
    
     int[] result = new int[((max - min) / step)+1];
     if (result.Length == 1)
        return [1];

     for (int i = 0; i < result.Length; i++)
       result[i] = min + (step * i);
     return result;
  }
}