using System;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            //Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //Create a function called calculator, that has three parameters.The first one is operator and then two numbers.
            //Depending on the value of the operator, call the corresponding function from the four ones from above.

            Console.WriteLine("Simple Calculator: +, -, *, /");
            Console.WriteLine("Enter the operator");
            string operation = Console.ReadLine();

            if(operation != "-" && operation != "+" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operator!");
            }

            Console.WriteLine("Enter the first number:");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstNum);

            Console.WriteLine("Enter the second number:");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondNum);

            if (!firstInput || !secondInput)
            {
                Console.WriteLine("Invalid input for numbers!");
                return;
            }

            if (operation == "+")
            {
                int result = Sum(firstNum, secondNum);
                Console.WriteLine($"The sum result of {firstNum} {operation} {secondNum} is: {result}!");
            }
            else if(operation == "-")
            {
                int result = Substract(firstNum, secondNum);
                Console.WriteLine($"The substract result of {firstNum}  {operation} {secondNum} is {result}!");
            }
            else if (operation == "*")
            {
                int result = Multiplication(firstNum, secondNum);
                Console.WriteLine($"The multiplication result of {firstNum} {operation} {secondNum} is {result}!");
            }
            else 
            {
                int result = Division(firstNum, secondNum);
                Console.WriteLine($"The division result of {firstNum} {operation} {secondNum} is {result}!");
            }
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiplication (int num1, int num2)
        {
            return num1 * num2;
        }
        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
