namespace GumballMachine
{
    public class SoldOutState : IState
    {   
        GumballMachineClass gumballMachine;

        public SoldOutState(GumballMachineClass gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
    
        }
        public void EjectQuarter()
        {
            System.Console.WriteLine("You have not inserted a quarter");
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You inserted a quarter");
           
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned, but there is no quarter");
        }
    }
}