using System;

class PoleVault
{
    public static double StartingMark(double bodyHeight)
    {
        // Remember: Body height of 1.52 m --> starting mark: 9.45 m
        //           Body height of 1.83 m --> starting mark: 10.67 m
        // All other starting marks are based on these guidelines!
      
        // bestStartingMark = mh + b
        double m = (9.45 - 10.67) / (1.52 - 1.83);
        double b = 9.45 - (m * 1.52) ; 
        double bestStartingMark = m*bodyHeight + b;
        return Math.Round(bestStartingMark, 2);

    }
}