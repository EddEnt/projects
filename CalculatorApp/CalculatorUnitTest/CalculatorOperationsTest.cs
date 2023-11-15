using CalculatorLibrary;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorOperationsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double num1 = 5;
            double num2 = 7;
            string op = "a";

            // Act
            double result = calculator.DoOperation(num1, num2, op);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}