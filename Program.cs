using System;
using System.Globalization;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // creat a Calculator 
            Calculator calculator = new Calculator();

            // variables
            String ans = null;
            var option = "";

            do
            {
                double number1 = 0;
                double number2 = 0;
                double resulat = 0;
                var thereIsNoInvalidOption = true;

                Console.Clear();

                calculator.ShowHeader();

                try
                {
                    Console.WriteLine("Inter The First Number :");
                    number1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Inter The secend Number :");
                    number2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    thereIsNoInvalidOption = false;
                    Console.WriteLine(ex.Message);
                }

                if (thereIsNoInvalidOption)
                {
                    // Showing Calc's Options
                    calculator.CalculatorOptions();

                    Console.WriteLine("Choose an option :");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "+":
                            resulat = calculator.Sum(number1, number2);
                            break;
                        case "-":
                            resulat = calculator.Sub(number1, number2);
                            break;
                        case "*":
                            resulat = calculator.Mul(number1, number2);
                            break;
                        case "/":
                            resulat = calculator.Div(number1, number2);
                            if (number2 == 0)
                                System.Console.WriteLine("Cant Divide By Ziro!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;

                    }

                }

                Console.WriteLine($"Your resulat is : {resulat}");
                Console.WriteLine("If You Want To Quiet Press \"N\" : ");
                ans = Console.ReadLine().ToUpper();

            }
            while (ans != "N");
        }
    }
}
