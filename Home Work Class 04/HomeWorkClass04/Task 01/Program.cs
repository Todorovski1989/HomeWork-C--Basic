using System;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Take one string from the input and print its last 5 characters.
            Console.WriteLine("Please enter one word with at least 6 characters:");
            Result(Console.ReadLine());
            
            
        }
        static string Result(string userInput)
        {
            string subStringer = userInput.Substring(userInput.Length - 5);
            Console.WriteLine($"You enter the word {userInput}! The last five characters of your input are: {subStringer}");
            return subStringer;
        }
    }
}
