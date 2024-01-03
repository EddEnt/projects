using CalculatorLibrary;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorAdditionTests
    {
        [TestMethod]
        public void TestMethodAddition()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double num1 = 5;
            double num2 = 7;
            string operation = "a";

            // Act
            double result = calculator.DoOperation(num1, num2, operation);

            // Assert
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void TestMethodPositiveSubtraction()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 24;
            double num2 = 13;
            string operation = "s";

            //Act
            double result = calculator.DoOperation(num1, num2, operation);

            //Assert
            Assert.AreEqual(11, result);

        }
    }

    [TestClass]
    public class CalculatorSubtractionTests
    {
        [TestMethod]
        public void TestMethodPositiveSubtraction()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 24;
            double num2 = 13;
            string operation = "s";

            //Act
            double result = calculator.DoOperation(num1, num2, operation);

            //Assert
            Assert.AreEqual(11, result);

        }

        [TestMethod]
        public void TestMethodNegativeSubtraction()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 25;
            double num2 = 32;
            string operation = "s";

            //Act
            double result = calculator.DoOperation(num1, num2, operation);

            //Assert
            Assert.AreEqual(-7, result);

        }

    }

    [TestClass]
    public class CalculatorMultiplicationTests
    {
        [TestMethod]
        public void TestMethodMultiplication()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 11;
            double num2 = 9;
            string operation = "m";

            //Act
            double result = calculator.DoOperation(num1, num2, operation);

            //Assert
            Assert.AreEqual(99, result);

        }
    }

    [TestClass]
    public class CalculatorDivisionTests
    {
        [TestMethod]
        public void TestMethodDivision()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 12;
            double num2 = 4;
            string operation = "d";

            //Act
            double result = calculator.DoOperation(num1, num2, operation);

            //Assert
            Assert.AreEqual(3, result);

        }
    }
}