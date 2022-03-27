using System;

namespace SumOfEvenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven.
            //Inside it create an array of 6 integers.Find and print the sum of the even numbers from the array:

            //Test Data:
            //Enter integer no.1:
            //4
            //Enter integer no.2:
            //3
            //Enter integer no.3:
            //7
            //Enter integer no.4:
            //3
            //Enter integer no.5:
            //2
            //Enter integer no.6:
            //8
            //Expected Output:
            //The result is: 14

            int[] integerArray = new int[6];
            integerArray[0] = 4;
            integerArray[1] = 3; 
            integerArray[2] = 7;
            integerArray[3] = 3;
            integerArray[4] = 2;
            integerArray[5] = 8;

            int sumResult = 0;

            for(int i = 0; i < integerArray.Length; i++)
            {
                if(integerArray[i] % 2 == 0)
                {
                    sumResult += integerArray[i];
                }
            }
            Console.WriteLine($"The sum of all even numbers is: {sumResult}");

            //Bonus :)
            for(int i = 0; i < integerArray.Length; i++)
            {
                if(integerArray[i % 2] != 0)
                {
                    sumResult -= integerArray[i];
                }
            }
            Console.WriteLine($"The diference of all odd numbers is: {sumResult}");
        }
    }
}
