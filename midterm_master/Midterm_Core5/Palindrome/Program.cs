using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static bool IsPalindrome(string text)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            foreach (char c in text){
                stack.Push(c);
                queue.Enqueue(c);
            }
            while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
                return true;
            
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or phrase to be checked as a Palindrome.");
            string input = Console.ReadLine();
            if (IsPalindrome(input))
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
