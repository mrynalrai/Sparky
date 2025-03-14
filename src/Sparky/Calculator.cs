﻿namespace Sparky;

public class Calculator
{
    public int AddNumbers(int a, int b)
    {
        return a+b;
    }

    public double AddNumbers(double a, double b)
    {
        return a+b; // Could use Math.Round(a + b, 10) to avoid unexpected floating point precision issues
    }

    public bool IsOddNumber(int a)
    {
        return a%2 != 0;
    }
}
