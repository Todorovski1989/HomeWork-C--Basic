using System;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Take a sentence as input and find its words.
            Console.WriteLine("Please enter a sentence:");
            SentenceResult(Console.ReadLine());
            
        }
        static string[] SentenceResult(string inputSentence)
        {
            string[] sentence = inputSentence.Split(' ');
            Console.WriteLine($"The sentence you entered have {sentence.Length} words and they are:");
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
            return sentence;
        }
    }
}
