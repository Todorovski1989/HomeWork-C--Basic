using System;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today

            Console.WriteLine("Welcome to AgeCalculator App.");
            Console.WriteLine("Please enter your birth date in order mm/dd/yy");

            DateTime dateTime = GetInput();
            int age = AgeCalculator(dateTime);
            Console.WriteLine($"You are {age} years old!");
        }
        public static DateTime GetInput()
        {
            DateTime birthDay;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
            {
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Please enter your birth date in order mm/dd/yy");
            }
            return birthDay;
        }
        public static int AgeCalculator(DateTime input)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - input.Year;
            if (today.Month < input.Month && today.Month == input.Month)
            {
                age--;
            }
            return age;
        }
    }
}
