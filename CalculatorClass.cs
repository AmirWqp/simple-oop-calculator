using System;


namespace Calculator
{
    public class Calculator
    {

        string option1 = "+";
        string option2 = "-";
        string option3 = "*";
        string option4 = "/";

        public void CalculatorOptions()
        {
            Console.WriteLine($"Calculator Options\n Add : {option1}\n Substract : {option2}\n Multiply : {option3}\n Divide : {option4}");
        }


        public void ShowHeader()
        {
            Console.WriteLine("----------\nCalculator\n----------");
        }

        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
        public double Mul(double number1, double number2)
        {
            return number1 * number2;
        }
        public double Div(double number1, double number2)
        {
            if (number2 != 0)
                return number1 / number2;
            else
                return 0;

        }
    }

}