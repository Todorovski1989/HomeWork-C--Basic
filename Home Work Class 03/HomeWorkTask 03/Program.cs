using System;

namespace HomeWorkTask_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a number as an input.
            //Print all the numbers except the numbers divisible by 5.
            //When you come to 80, the limit is reached.

            Console.WriteLine("Enter a number:");
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }

                if (i >= 80)
                {
                    Console.WriteLine("The limit is reached");
                    break;
                }
                Console.WriteLine(i);

                
            }
        }
    }
}
