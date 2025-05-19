using System;

namespace Eliza
{
    class Program
    {
        static string CreateElizaResponse(string clientStatement)
        {
            string statement = clientStatement.ToLower();
            if (statement.Contains("my"))
            {

            } else if statement.Contains("love") || statement.Contains("hate") {
                return "You have strong feelings about that!";
            } else {
                defaultResponces = { };
                //int randomIndex = Random
                return defaultResponses[randomIndex];
            }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string response = CreateElizaResponse(input);
            Console.WriteLine(response);
        }
    }
}
