using System;

namespace SingleResponsibility.UserInputs.Setup
{
    public class Setup
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the application");

            Person person = new Person();

            Console.Write("What is your Firstname?");
            person.FirstName = Console.ReadLine();

            Console.Write("What is your Lastname?");
            person.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.Write("Please enter a valid firstname: ");
                Console.ReadLine();
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.Write("Please enter a valid lastname: ");
                Console.ReadLine();
            }

            Console.WriteLine($"Your username is {person.FirstName.Substring(0,3)}{person.LastName.Substring(0,1)}");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}