using System;

namespace HomeWork02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            float inputOne;
            float inputTwo;
            float inputThree;
            float inputFour;

            float result;
            Console.WriteLine("Welcome to AverageNumber App!");
            Console.WriteLine("Enter four numbers to calculate the average!");
            Console.WriteLine("Enter your first number:");
            inputOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            inputTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third number:");
            inputThree = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fourth number:");
            inputFour = int.Parse(Console.ReadLine());

            result = (inputOne + inputTwo + inputThree + inputFour) / 4;
            Console.WriteLine($"The average result of {inputOne} , {inputTwo} , {inputThree} , {inputFour} is {result} ");
        }
    }
}
