using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0; 
            double number2 = 0;
            double result = 0;

            Console.WriteLine("Enter a number:");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operand(+, -, *, /):");
            char operand = Console.ReadLine()[0];

            Console.WriteLine("Enter second number:");
            number2 = double.Parse(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number1 == 0)
                    {
                        Console.WriteLine("Error: Can not divide by zero");
                        return;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }
            Console.WriteLine("{0} {1} {2} = {3}", number1, operand, number2, result);
        }
    }
}