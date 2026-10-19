using System;

public static class Kata
{
  public static string ToCsvText(int[][] array)
  {
        string CSVResult = "";
        for (int i = 0; i < array.Length; i++)
        {
            for(int j=0; j< array[i].Length; j++)  
                if (j + 1 != array[i].Length) CSVResult += array[i][j] + ",";
                else CSVResult += array[i][j];
            
            if (i + 1 != array.Length) CSVResult += "\n";          
        }
        return CSVResult;   
  }
}