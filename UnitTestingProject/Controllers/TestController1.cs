using Calculator.Test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitTestingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController1 : ControllerBase
    {
        //Injected a test service name IPrinterService
        private IPrinterService _printerService;
        public TestController1(IPrinterService printerService) 
        {
            _printerService = printerService;
        }


        public static int Divide(int numerator, int denominator) 
        {
            int result = numerator / denominator;
            return result;
        }

        public static int Calculator(int number1, int number2, int computation)
        {
            int result = 0;
            if (computation > 0)
            {
                switch (computation)
                {
                    case 1:
                        result = number1 + number2;
                        break;
                    case 2:
                        result = number1 - number2;
                        break;
                    case 3:
                        result = number1 / number2;
                        break;
                    case 4:
                        result = number1 * number2;
                        break;
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static string GradeCalculator(int marks)
        {
            string grade = string.Empty;
            if(marks >= 90 && marks <= 99)
            {
                grade = "A+";
            }
            else if (marks >= 80 && marks <= 89)
            {
                grade = "A";
            }
            else if (marks >= 60 && marks <= 79)
            {
                grade = "B+";
            }
            else if (marks >= 30 && marks <= 59)
            {
                grade = "P";
            }
            return grade;
        }


        public string GuessedNumber(int guessNumber)
        {
            string result = string.Empty;
            if(guessNumber > 100)
            {
                result = "Try a smaller number";

            }
            else if (guessNumber < 100)
            {
                result = "Try a larger number";

            }
            else
            {
                result = "Correct!";
            }
            //For the tightly coupled class 
            MailServices mail = new MailServices();
            if (mail.IsMailAvailable())
            {
                mail.Sendmail(result);
            }

            //For the printerservice which we can inject through dependancy injection
            if (_printerService.IsPrinterAvailable())
            {
                _printerService.Print(result);
            }
            return result;
        }
    }
}
