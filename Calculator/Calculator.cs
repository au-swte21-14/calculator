using System;
using System.IO;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            double ret = Math.Pow(x, exp);
            if (Double.IsNaN(ret))
            {
                throw new InvalidDataException("Input is invalid");
            }

            return ret;

        }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }
        public double Accumulator { get; private set; }

        public void Clear()
        {
            Console.Clear();
        }
    }

}