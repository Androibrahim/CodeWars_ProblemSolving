using System.Linq;
using System;

public static class AgeDiff 
{
  public static string CalculateAge(int birth, int yearTo) 
  {
	  if(birth == yearTo)
      return "You were born this very year!";
    else if(birth < yearTo )
      {
        if( (yearTo - birth) == 1 )
          return $"You are {yearTo-birth} year old.";
      else
          return $"You are {yearTo-birth} years old.";
      }
    else
      {
          if( (birth - yearTo) == 1 )
             return $"You will be born in {birth - yearTo} year.";
          else
             return $"You will be born in {birth - yearTo} years.";
      }
  }
}