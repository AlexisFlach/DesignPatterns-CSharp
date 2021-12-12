using System;
namespace SingleResponsibility.UserInputs.Solution
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Console.Write("What is your Firstname?");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your Lastname?");
            user.LastName = Console.ReadLine();
            return user;
        }
    }
}