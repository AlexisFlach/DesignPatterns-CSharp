using System;

namespace SingleResponsibility.UserInputs.Solution
{
    public class StandardMessages
    {
        public static void WelcomeMessage() {
           Console.WriteLine("Welcome to my Application");
        }
        public static void EndApplication()
        {
            Console.Write("Press enter to close");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName) => Console.WriteLine($"Please enter a valid {fieldName}");
    }
}