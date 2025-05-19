using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static bool IsPalindrome(string text)
        {
            //Set up stacks
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            //Put input into stack and queue in desired order
            foreach (char c in text){
                stack.Push(c);
                queue.Enqueue(c);
            }
            //Go until all checked
            while (stack.Count > 0 && queue.Count > 0)
            {
                //Checks "adjacent" characters
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            
            }
            return true;
        }
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Please enter a word or phrase to be checked as a Palindrome.");
            string input = Console.ReadLine();
            //Remove punctuation and capitilization
            string cleanedInput = "";
            foreach (char c in input) {
                if (char.IsLetterOrDigit(c)) {
                    cleanedInput += char.ToLower(c);
                }
            }
            //Shows result
            if (IsPalindrome(cleanedInput))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }
    }
}
