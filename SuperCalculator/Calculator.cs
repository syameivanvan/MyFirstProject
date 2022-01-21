using System;

namespace Tools
{
    public class Calculator
    {
        public static double Add(double a,double b)
        {
            return a + b;
        }
        public static double Sub(double a,double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0 is illegal!");
                return double.PositiveInfinity;
            }
            else
            {
                return a / b;
            }
        }
    }
}
