using System;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5
            //Create an array of integers.Get the number of elements and the values of the elements from input.
            //Find how many times there are two 3 next to each other.
            //Example:
            //Enter number of elements: 7
            //Enter first element: 9
            //Enter second element: 3
            //Enter third element: 3
            //Enter fourth element: 4
            //Enter fifth element: 3
            //Enter sixth element: 3
            //Enter seventh element: 3
            //Three times there are threes next to each other.

            Console.WriteLine("Find out how many times there are two 3 next to each other");
            Console.WriteLine("You can put only 7 elements/numbers!");
            Console.WriteLine("Please enter the number of elements:");
            int elements;

            while (!int.TryParse(Console.ReadLine(), out elements))
            {
                Console.WriteLine("Invalid input! enter a number!");
            }

            int[] inputArray = new int [elements];

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"Please enter value for {i + 1}:");
                if (!int.TryParse (Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Invalid input! Enter a number!");
                }
                inputArray[i] = input;
            }
            Console.WriteLine(Find(inputArray));
        }
        private static string Find(int [] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] == 3 && numbers[i + 1] == 3)
                {
                    counter++;
                }
            }

            switch (counter)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
            }
            return $"{counter} times there threes next to each other!";
        }
    }
}
