namespace Facade
{
    public class AccountNumberCheck
    {
        private int AccountNumber = 1234;

        public int GetAccountNumber()
        {
            return AccountNumber;
        }
        public bool AccountActive(int accNumToCheck)
        {
            if (accNumToCheck == GetAccountNumber())
            {
                return true;
            }
            return false;
        }
    }
}