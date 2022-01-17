namespace GumballMachine
{
    public class HasQuarterState : IState
    {
        GumballMachineClass gumballMachine;

        public HasQuarterState(GumballMachineClass gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.noQuarterState);
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You can not insert another quarter");
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}