namespace Facade
{
    public class FundsCheck
    {
        private double _cashInAccount = 1000.00;

        public double GetCashInAccount() { return _cashInAccount; }

        public void DecreaseCashInAccount(double cashWithdrawal)
        {
            _cashInAccount -= cashWithdrawal;
        }

        public void IncreaseCashInAccount(double cashWithdrawal)
        {
            _cashInAccount += cashWithdrawal;
        }

        public bool HaveEnoughMoney(double cashWithdrawal)
        {
            if (cashWithdrawal > GetCashInAccount())
            {
                System.Console.WriteLine("Sorry. You do not have enough money");
                System.Console.WriteLine("Current Balance: " + GetCashInAccount());
                return false;
            }
            DecreaseCashInAccount(cashWithdrawal);
            System.Console.WriteLine("Withdrawal successful. Current Balance: " + GetCashInAccount());
            return true;
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);
            System.Console.WriteLine("Deposit Complete: " + GetCashInAccount());
        }
    }
}