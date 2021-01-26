using System;

namespace Calculator
{
    public class Calculator
    {
        [Obsolete("This is broken. Use CalculateSomeNumberForPower12. This will be removed tomorrow.")]
        public double CalculateSomeNumber(int someNumber) => Calculate(someNumber, 16);

        public double CalculateSomeNumberForPower12(int someNumber) => Calculate(someNumber, 12);

        public double CalculateSomeNumberSmall(int someNumber) => CalculateSmall(someNumber);

        private static double CalculateSmall(int someNumber)
        {
            return Math.Pow(someNumber, 2);
        }

        private static double Calculate(int someNumber, int power)
        {
            return Math.Pow(someNumber, power);
        }
    }
}
