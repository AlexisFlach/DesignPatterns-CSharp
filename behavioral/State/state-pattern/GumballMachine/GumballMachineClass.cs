namespace GumballMachine
{
    public class GumballMachineClass
    {
        public IState soldOutState { get; set; }
        public IState noQuarterState { get; set; }
        public IState hasQuarterState { get; set; }
        public IState soldState { get; set; }
        public IState state { get; set; }
        public int count = 1;

        public GumballMachineClass(int numberGumball)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = numberGumball;

            if (numberGumball <= 0)
                state = soldOutState;

            state = noQuarterState;
        }

        public void InsertQuarter() =>
            state.InsertQuarter();

        public void EjectQuarter() =>
            state.EjectQuarter();

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void SetState(IState state) =>
            this.state = state;

        public void RealeaseBall()
        {
            System.Console.WriteLine("A gumball is rolling out the slot...");
            if (count > 0)
                count = count - 1;
        }


    }
}