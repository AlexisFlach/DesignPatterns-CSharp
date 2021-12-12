using static System.Console;
namespace SingleResponsibility.UserInputs.Solution
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError(person.FirstName);
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError(person.LastName);
                StandardMessages.EndApplication();
                return false;
            }
            return true;
        }
    }
}