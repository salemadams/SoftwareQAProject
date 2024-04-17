namespace CalculatorEngine;

using System;
public class CalculatorEngine
{
    private const int Precision = 8;

    //preq-ENGINE-3
    public static double Add(double x, double y)
    {
        return x + y;
    }

    //preq-ENGINE-4
    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    //preq-ENGINE-5
    public static double Multiply(double x, double y)
    {
        return x * y;
    }
    
    //preq-ENGINE-7
    public static double Divide(double x, double y)
    {
        return x / y;

        //var result = x / y;
        //if (double.IsInfinity((result))) return errorState
        //else return resulkt;
    }
    
    //preq-ENGINE-8
    public static bool Equals(double x, double y)
    {
        var tolerance = Math.Pow(10, -Precision);
        var absoluteValueOfDiff = Math.Abs(x - y);
        var isWithinTolerance = absoluteValueOfDiff <= tolerance;
        return isWithinTolerance;
    }
    
    //preq-ENGINE-9
    public static double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }
    
    //preq-ENGINE-10
    public static double Log(double x, double y)
    {
        return Math.Log(x, y);
    }
    
    //preq-ENGINE-11
     public static double Root(double x, double y)
     {
         if (y == 0) return double.NaN; //CHECK WITH PROFESSOR
        return Math.Pow(x, 1.0 / y);
    }
    
    
    //preq-ENGINE-12
    public static double Factorial(double x)
    {
        double result = 1;
        for (int i = 1; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }
    
    //preq-ENGINE-13
    public static double Sin(double x)
    {
        return Math.Sin(x);
    }
    
    //preq-ENGINE-14
    public static double Cos(double x)
    {
        return Math.Cos(x);
    }
    
    //preq-ENGINE-15
    public static double Tan(double x)
    {
        return Math.Tan(x);
    }
    
    //preq-ENGINE-16
    public static double Reciprocal(double x)
    {
        return 1 / x;
    }
}