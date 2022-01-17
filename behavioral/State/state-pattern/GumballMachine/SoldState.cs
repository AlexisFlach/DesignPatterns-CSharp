namespace GumballMachine
{
    public class SoldState : IState
    {
        GumballMachineClass gumballMachine;

        public SoldState(GumballMachineClass gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            gumballMachine.RealeaseBall();
            if (gumballMachine.count > 0)
            {
                gumballMachine.SetState(gumballMachine.noQuarterState);
            }
            else
            {
                System.Console.WriteLine("Out of gumballs");
                gumballMachine.SetState(gumballMachine.soldOutState);
            }
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