//https://www.codewars.com/kata/56c22c5ae8b139416c00175d/csharp

using StriveObjects;
using System;

public class Strive
{
  public static bool Match(Candidate c, Job j)
  {
    if(c.MinSalary == null || j.MaxSalary == null )
      throw new NotImplementedException();
  
   double? MinSalary = c.MinSalary ; 
   MinSalary-= MinSalary * 0.10 ; 
    if(MinSalary <= j.MaxSalary)
      return true ; 
    else
      return false ; 
  }
}