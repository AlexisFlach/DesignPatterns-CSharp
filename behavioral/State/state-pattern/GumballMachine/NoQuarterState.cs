namespace GumballMachine
{
    public class NoQuarterState : IState
    {   
        GumballMachineClass gumballMachine;

        public NoQuarterState(GumballMachineClass gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            System.Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("You have not inserted a quarter");
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.hasQuarterState);
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned, but there is no quarter");
        }
    }
}