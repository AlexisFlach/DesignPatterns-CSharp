namespace SingleResponsibility.UserInputs.Solution
{
    public class Program
    {
        public static void Run()
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}