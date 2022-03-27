using System;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            //Create a function that takes a number as input.This method should return the sum of the digits in the number.
            Console.WriteLine("Please enter a number with at least 2 digits!");
            Console.WriteLine("Enter a number:");

            
            if (!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter a number:");
            }
                Sum(userInput);

        }

        public static int Sum(int input)
        {
            int result = 0;
            while (input != 0)
            {
                result += input % 10;
                input = input / 10;
            }
            Console.WriteLine($"The sum of the digits you entered is: {result}");
            return result;
        }
    }
}
