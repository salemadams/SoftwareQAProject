namespace CalculatorEngine;

using System;
public class CalculatorEngine
{
    private const int Precision = 8;
    private Result _Result;
    
    //preq-ENGINE-3
    public Result Add(double x, double y)
    {
        _Result = new Result
        {
            IsSuccess = true,
            Output = x + y
        };
        return _Result;
    }

    //preq-ENGINE-4
    public Result Subtract(double x, double y)
    {
        _Result = new Result
        {
            IsSuccess = true,
            Output = x - y
        };
        return _Result;
    }

    //preq-ENGINE-5
    public Result Multiply(double x, double y)
    {
        _Result = new Result
        {
            IsSuccess = true,
            Output = x * y
        };
        return _Result;
    }
    
    //preq-ENGINE-7
    public Result Divide(double x, double y)
    {
        var result = x / y;
        if (double.IsInfinity(result))
        {
            _Result = new Result
            {
                IsSuccess = false,
                ErrorMessage = "Not a Number"
            };
        }
        else
        {
            _Result = new Result
            {
                IsSuccess = true,
                Output = x / y
            };
        }
        return _Result;
    }
    
    //preq-ENGINE-8
    public Result Equals(double x, double y)
    {
        var tolerance = Math.Pow(10, -Precision);
        var absoluteValueOfDiff = Math.Abs(x - y);
        var isWithinTolerance = absoluteValueOfDiff <= tolerance;
        if (isWithinTolerance)
        {
            _Result = new Result
            {
                IsSuccess = true,
                Output = 1
            };
        }
        else
        {
            _Result = new Result
            {
                IsSuccess = true,
                Output = 0
            };
        }
        return _Result;
    }
    
    //preq-ENGINE-9
    public Result Power(double x, double y)
    {
        _Result = new Result
        {
            IsSuccess = true,
            Output = Math.Pow(x, y)
        };
        return _Result;
    }
    
    //preq-ENGINE-10
    public Result Log(double x, double y)
    {
        if (x <= 0)
        {
            _Result = new Result
            {
                IsSuccess = false,
                ErrorMessage = "Negative Logarithm Input"
            };
        }
        else if (y == 0)
        {
            _Result = new Result
            {
                IsSuccess = false,
                ErrorMessage = "Base of Zero"
            };
        }
        else
        {
            _Result = new Result
            {
                IsSuccess = true,
                Output = Math.Log(x, y)
            };
        }
        return _Result;
    }
    
    //preq-ENGINE-11
     public Result Root(double x, double y)
     {
         if (y == 0)
         {
             _Result = new Result
             {
                 IsSuccess = false,
                 ErrorMessage = "Negative Root Value"
             };
         }
         else
         {
             _Result = new Result
             {
                 IsSuccess = true,
                 Output = Math.Pow(x, 1.0 / y)
             };
         }
         return _Result; //CHECK WITH PROFESSOR
    }
    
    
    //preq-ENGINE-12
    public Result Factorial(double x)
    {
        double result = 1;
        if (x < 0)
        {
            for (int i = 1; i <= x * -1; i++)
            {
                result *= i;
            }
            result *= -1;
        }
        else
        {
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }   
        }
        _Result = new Result
        {
            IsSuccess = true,
            Output = result
        };
        return _Result;
    }
    
    //preq-ENGINE-13
    public Result Sin(double x)
    {
        var radians = (x * (Math.PI)) / 180;
        _Result = new Result
        {
            IsSuccess = true,
            Output = Math.Sin(radians)
        };
        return _Result;
    }
    
    //preq-ENGINE-14
    public Result Cos(double x)
    {
        var radians = (x * (Math.PI)) / 180;
        _Result = new Result
        {
            IsSuccess = true,
            Output = Math.Cos(radians)
        };
        return _Result;
    }
    
    //preq-ENGINE-15
    public Result Tan(double x)
    {
        var radians = (x * (Math.PI)) / 180;
        _Result = new Result
        {
            IsSuccess = true,
            Output = Math.Tan(radians)
        };
        return _Result;
    }
    
    //preq-ENGINE-16
    public Result Reciprocal(double x)
    {
        if (x == 0)
        {
            _Result = new Result
            {
                IsSuccess = false,
                ErrorMessage = "Not a Number"
            };
        }
        else
        {
            _Result = new Result
            {
                IsSuccess = true,
                Output = 1 / x
            };
        }
        return _Result;
    }
}

public class Result
{
    public double Output { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; } = "";
}