using System;

namespace HomeWorkTask04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application.
            //Create an array of 10 whole numbers(integers).
            //Find the minimum and maximum and print them in the console.

            Console.WriteLine("Finding the minimum and maximum numbers:");

            int[] tenArray = new int[10] { 55, 185, 22, 12, 999, 482, 777, 31, 298, 999 };
            int i, max, min;

            max = tenArray[0];
            min = tenArray[0];

            for (i = 1; i < tenArray.Length; i++)
            {
                if (tenArray[i] > max)
                {
                    max = tenArray[i];
                }
                if (tenArray[i] < min)
                {
                    min = tenArray[i];
                }
            }
            Console.WriteLine($"The minimum number is: {min} and the maximum number is: {max}");
        }
    }
}
