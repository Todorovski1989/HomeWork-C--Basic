using System;
using Task_02.Models;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            //Call the GetPersonStats method and print the result in the console after the object is created;

            Console.WriteLine("Please enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your Age:");
            int age = int.Parse(Console.ReadLine());

            Human human = new Human();
            human.FirstName = firstName;
            human.LastName = lastName;
            human.Age = age;

            string stats = human.GetPersonStats(firstName, lastName, age);
            Console.WriteLine(stats);
        }
    }
}
