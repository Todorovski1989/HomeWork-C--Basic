using System;

namespace FindStatisticsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new console application “FindStatistics”.
            // Input 2 numbers.If the two of them are even, print their sum, if one of them is odd, print their difference,
            // if the two off them are odd, multiply them.
            // Don't print just the result, but also the whole operation. Treat zero as even. Please find example below:

            //Test Data:
            //Input the First Number: 8
            //Input the Second Number: 5
            //Expected Output:
            //One of the numbers is odd.The operation and result are 8 - 5 = 3.

            Console.WriteLine("Please enter two numbers to find statistics!");
            Console.WriteLine("Enter the first number:");
            bool parsedInputOne = int.TryParse(Console.ReadLine(), out int inputOne);

            Console.WriteLine("Enter the second number:");
            bool parsedInputTwo = int.TryParse(Console.ReadLine(), out int inputTwo);

            int result;

            if (parsedInputOne && parsedInputTwo)
            {
                if(inputOne % 2 == 0 && inputTwo % 2 == 0)
                {
                    result = inputOne + inputTwo;
                    Console.WriteLine($"The two numbers you entered: {inputOne} and {inputTwo} are even, the operation and the result are: {inputOne} + {inputTwo} = {result}.");
                }
                else if (inputOne % 2 != 0 && inputTwo % 2 != 0)
                {
                    result = inputOne * inputTwo;
                    Console.WriteLine($"The two numbers you entered: {inputOne} and {inputTwo} are odd, the operation and the result are: {inputOne} * {inputTwo} = {result}.");
                }
                else if (inputOne % 2 != 0 || inputTwo % 2 != 0)
                {
                    result = inputOne - inputTwo;
                    Console.WriteLine($"One of the numbers is odd.The operation and result are {inputOne} - {inputTwo} = {result}.");
                }
                else
                {
                    throw new Exception("Error!");
                }

            }
            else
            {
                Console.WriteLine("Invalid input! Please try again");
            }
        }
    }
}
