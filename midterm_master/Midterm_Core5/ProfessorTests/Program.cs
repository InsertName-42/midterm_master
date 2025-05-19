using System;
using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testing Professor Class ---");

            //Test the constructor
            Console.WriteLine("\n--- Testing Constructor ---");
            try
            {
                Professor professor1 = new Professor("L12345", "Jane", "Tyler", "Computer Science");
                Console.WriteLine($"Professor 1: {professor1}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating professor: {ex.Message}");
            }

            try
            {
                Professor invalidProfessor = new Professor("", "Greg", "Matthews", "Mathematics");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid professor: {ex.Message}");
            }

            //Test properties (getters and setters)
            Console.WriteLine("\n--- Testing Properties ---");
            Professor professor2 = new Professor("L67890", "Charlie", "Brown", "Physics");
            Console.WriteLine($"Initial Professor 2: {professor2}");

            professor2.FirstName = "Charles";
            professor2.LastName = "Browne";
            professor2.Department = "Astrophysics";
            Console.WriteLine($"After updates: {professor2}");

            professor2.FirstName = "";
            Console.WriteLine($"After setting empty first name: {professor2}");

            //Lnumber (read-only)
            Console.WriteLine("\n--- Testing Lnumber (Read-only) ---");
            Professor professor3 = new Professor("L00112", "Elizabeth", "Madison", "Chemistry");
            Console.WriteLine($"Professor 3 Lnumber: {professor3.Lnumber}");

            //ToString() method
            Console.WriteLine("\n--- Testing ToString() ---");
            Console.WriteLine($"Professor 3 string representation: {professor3}");

            Console.WriteLine("\n--- Tests Completed ---");
        }
    }
}