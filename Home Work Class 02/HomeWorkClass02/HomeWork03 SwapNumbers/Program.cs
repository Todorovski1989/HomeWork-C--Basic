using System;

namespace HomeWork03_SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            int inputOne;
            int inputTwo;
            int mix;

            Console.WriteLine("Welcome to SwapNumbers App!");
            Console.WriteLine("Enter the numbers you want to swap:");
            Console.WriteLine("Enter the first number:");
            while(!Int32.TryParse(Console.ReadLine(), out inputOne))
            {
                Console.WriteLine("Invalid number, please try again!");
                Console.WriteLine("Enter the first number:");
                
            }
            Console.WriteLine("Enter the second number:");
            while (!Int32.TryParse(Console.ReadLine(), out inputTwo))
            {
                Console.WriteLine("Invalid number, please try again!");
                Console.WriteLine("Enter the second number:");
            }

            Console.WriteLine($"The numbers you want to swipe are {inputOne} and {inputTwo}");

            mix = inputOne;
            inputOne = inputTwo;
            inputTwo = mix;

            Console.WriteLine($"After Swapping the numbers are: first number - {inputOne}, second number - {inputTwo}");
        }
    }
}
