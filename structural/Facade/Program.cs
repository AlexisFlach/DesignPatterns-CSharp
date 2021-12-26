using Facade;

BankAccountFacade accessingBank = new BankAccountFacade(1234, 1234);

accessingBank.DepositCash(1000);

accessingBank.WithdrawCash(500);