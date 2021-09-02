using System;
using System.IO;

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
            Console.WriteLine(("2 / 2 er ") + calc.Divide(2,2));
            
            
            try 
            {
                Console.WriteLine("(-2) ^ 2.2 er " + calc.Power(-2,2.2));
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e);
                
            }
        }
    }
}