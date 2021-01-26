using System;
using Calculator;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator.Calculator();
            var result = calculator.CalculateSomeNumberForPower12(45);
            Console.WriteLine(result);
        }
    }
}
