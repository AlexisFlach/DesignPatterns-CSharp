namespace Facade
{
    public class BankAccountFacade
    {
        private int _accountNumber;
        private int _securityCode;

        AccountNumberCheck accountNumberChecker;
        SecurityCodeCheck securityCodeChecker;
        FundsCheck fundsChecker;

        WelcomeToBank bankWelcome;

        public BankAccountFacade(int newAccountNumber, int newSecCode)
        {
            _accountNumber = newAccountNumber;
            _securityCode = newSecCode;

            bankWelcome = new WelcomeToBank();
            accountNumberChecker = new AccountNumberCheck();
            securityCodeChecker = new SecurityCodeCheck();
            fundsChecker = new FundsCheck();
        }

        public int GetAccountNumber() { return _accountNumber; }
        public int GetSecurityCode() { return _securityCode; }

        public void WithdrawCash(double cashToWithdraw)
        {
            if (accountNumberChecker.AccountActive(GetAccountNumber()) &&
                securityCodeChecker.IsCodeCorrect(GetSecurityCode()) &&
                fundsChecker.HaveEnoughMoney(cashToWithdraw)
            )
            {
                System.Console.WriteLine("Transaction Complete\n");
            }
            else
            {
                System.Console.WriteLine("Transaction Failed");
            }

        }
        public void DepositCash(double cashToDeposit)
        {
            if (accountNumberChecker.AccountActive(GetAccountNumber()) &&
                securityCodeChecker.IsCodeCorrect(GetSecurityCode())
            )
            {
                fundsChecker.MakeDeposit(cashToDeposit);
                System.Console.WriteLine("Transaction Complete\n");
            }
            else
            {
                System.Console.WriteLine("Transaction Failed");
            }

        }
    }
}