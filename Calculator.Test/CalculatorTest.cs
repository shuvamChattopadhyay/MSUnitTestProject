using UnitTestingProject.Controllers;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act
            int actual_result = TestController1.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual_result);   
        }

        [TestMethod]
        public void Test_Multiply()
        {
            //Arrange
            int expected = 100;
            int number1 = 20;
            int number2 = 5;

            //Act
            int actual_result = TestController1.Calculator(number1,number2,4);

            //Assert
            Assert.AreEqual(expected, actual_result);
        }

        [TestMethod]
        public void Test_Addition()
        {
            //Arrange
            int number1 = -20;
            int number2 = 5;
            int expected = -15;


            //Act
            int actual_result = TestController1.Calculator(number1, number2, 1);

            //Assert
            Assert.AreEqual(expected, actual_result);
        }

        [TestMethod]
        public void Test_GradeCalculator()
        {
            //Arrange
            int marks = 73;
            string expected = "B+";


            //Act
            string actual_result = TestController1.GradeCalculator(marks);

            //Assert
            Assert.AreEqual(expected, actual_result);
        }

        [TestMethod]
        public void TestController1_GuessedNumber_small()
        {
            //Arrange
            //Mocking the actual IPrintService here..
            IPrinterService mock_service = new PrintService();
            TestController1 controller = new TestController1(mock_service);

            int input = 500;
            string expected = "Try a smaller number";

            //Act
            string actual = controller.GuessedNumber(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //To make a test case that accepts multiple input for different test cases

        [TestMethod]
        [DataRow(500, "Try a smaller number")]
        [DataRow(80, "Try a larger number")]
        [DataRow(100, "Correct!")]
        public void Test_Controller1_GuessedNumber_Multiple(int guessedNumber, string expectedResult)
        {
            //Arrange
            //Mocking the actual IPrintService here..
            IPrinterService mock_service = new PrintService();
            TestController1 controller = new TestController1(mock_service);

            //Act
            string actual = controller.GuessedNumber(guessedNumber);

            //Assert
            Assert.AreEqual(expectedResult, actual);
            //In AreSame method the passed two values should be of same object
            //Assert.AreSame(expectedResult, actual);

            //If the value is not null throws an exception
            //Assert.IsNull(actual);
            //If the value is null throws an exception
            Assert.IsNotNull(actual);
        }

    }
}