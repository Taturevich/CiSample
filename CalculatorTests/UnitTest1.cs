using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
    public class Tests
    {
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(2, 65536)]
        [TestCase(12, 184_884_258_895_036_416)]
        public void CalculateSomeNumber(int someNumber, double calculationResult)
        {
            // Arrange
            var calculator = new Calculator.Calculator();

            // Act
            var result = calculator.CalculateSomeNumber(someNumber);

            // Assert
            Assert.That(result, Is.EqualTo(calculationResult));
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(2, 4)]
        [TestCase(12, 144)]
        public void CalculateSomeNumberSmall(int someNumber, double calculationResult)
        {
            // Arrange
            var calculator = new Calculator.Calculator();

            // Act
            var result = calculator.CalculateSomeNumberSmall(someNumber);

            // Assert
            Assert.That(result, Is.EqualTo(calculationResult));
        }
    }
}