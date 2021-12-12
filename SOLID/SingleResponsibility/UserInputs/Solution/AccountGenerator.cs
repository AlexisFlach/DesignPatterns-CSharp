using static System.Console;

namespace SingleResponsibility.UserInputs.Solution
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            WriteLine($"Your username is {user.FirstName.Substring(0, 2)} {user.LastName.Substring(0, 2)}");
        }
    }
}