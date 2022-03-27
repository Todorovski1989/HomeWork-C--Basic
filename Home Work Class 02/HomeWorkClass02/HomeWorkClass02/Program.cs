using System;

namespace HomeWorkClass02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //The result is: 25

            float inputOne;
            float inputTwo;

            string operation;
            float result;

            Console.WriteLine("Welcome to RealCalculator App!");


            Console.WriteLine("Enter your first number:");
            inputOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            inputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation you want to be done (+ , - , * , /):");
            operation = Console.ReadLine();
            if(operation == "+")
            {
                result = inputOne + inputTwo;
                Console.WriteLine($"{inputOne} + {inputTwo} = {result}");
            }
            else if(operation == "-")
            {
                result = inputOne - inputTwo;
                Console.WriteLine($"{inputOne} - {inputTwo} = {result}");
            }
            else if (operation == "*")
            {
                result = inputOne * inputTwo;
                Console.WriteLine($"{inputOne} * {inputTwo} = {result}");
            }
            else if(operation == "/")
            {
                result = inputOne / inputTwo;
                Console.WriteLine($"{inputOne} / {inputTwo} = {result}");
            }
            else
            {
                Console.WriteLine("You enter invalid operation!");
            }

        }
    }
}
