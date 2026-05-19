using System;
using System.Text.RegularExpressions;

namespace Eliza
{
    class Program
    {
        private static readonly Random _random = new Random();
        static string CreateElizaResponse(string clientStatement)
        {
            //Remove capitilization
            string statement = clientStatement.ToLower();
            //Check for key words
            if (Regex.IsMatch(statement, @"\bmy\b"))
            {
                //Get word after my
                Match match = Regex.Match(statement, @"\bmy\b");
                int myIndex = match.Index;

                string afterMy = statement.Substring(myIndex + 3);
                string[] splitStatement = afterMy.Split(' ');
                //Return to be displayed
                return $"Tell me more about your {splitStatement[0]}.";
            }
            else if (statement.Contains("love") || statement.Contains("hate"))
            {
                //Consistent response
                return "You have strong feelings about that!";
            }
            else
            {
                //Randomized is no key words
                string[] defaultResponses = { "Please go on.", "Tell me more", "Continue." };
                int randomIndex = _random.Next(defaultResponses.Length);
                return defaultResponses[randomIndex];
            }
        }
            static void Main(string[] args)
            {
                //Introduction
                Console.WriteLine("Hello! I am Eliza, here for all of your mental health needs. What is on your mind?");
                //Loop forever
                do
                {
                    string input = Console.ReadLine();
                    string response = CreateElizaResponse(input);
                    Console.WriteLine(response);
                }
                while (true);
            }
        }
}
