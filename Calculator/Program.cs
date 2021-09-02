using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("1 + 1 er " + calc.Add(1, 1));
            Console.WriteLine("2 * 2 er " + calc.Multiply(2, 2));
            Console.WriteLine("2 - 2 er " + calc.Subtract(2, 2));
            Console.WriteLine("2 ^ 2 er " + calc.Power(2, 2));
        }
    }
}