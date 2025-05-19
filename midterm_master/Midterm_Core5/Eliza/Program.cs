using System;

namespace Eliza
{
    class Program
    {
        static string CreateElizaResponse(string clientStatement)
        {
            //Remove capitilization
            string statement = clientStatement.ToLower();
            //Check for key words
            if (statement.Contains("my"))
            {
                //Get word after my
                int myIndex = statement.IndexOf("my ");
                string afterMy = statement.Substring(myIndex + 3);
                string[] splitStatement = afterMy.Split(' ');
                //Return to be displayed
                return $"Tell me more about your {splitStatement[0]}.";
            }
            else if (statement.Contains("love") || statement.Contains("hate"))
            {
                //Consistent responce
                return "You have strong feelings about that!";
            }
            else
            {
                //Randomized is no key words
                string[] defaultResponces = { "Please go on.", "Tell me more", "Continue." };
                Random random = new Random();
                int randomIndex = random.Next(2);
                return defaultResponces[randomIndex];
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
