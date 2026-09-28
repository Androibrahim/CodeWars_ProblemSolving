using System;
using System.Collections.Generic;

public class AddMore
    {
        public static List<int> AddExtra(List<int> listOfNumbers)
        {
          listOfNumbers.Add(5);
          return listOfNumbers;
        }
    }