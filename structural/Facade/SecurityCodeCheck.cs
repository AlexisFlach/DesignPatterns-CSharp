namespace Facade
{
    public class SecurityCodeCheck
    {
        private int _securityCode = 1234;

        public int GetSecurityCode()
        {
            return _securityCode;
        }

        public bool IsCodeCorrect(int secCodeToCheck)
        {
            if (secCodeToCheck == GetSecurityCode())
            {
                return true;
            }
            return false;
        }

    }
}