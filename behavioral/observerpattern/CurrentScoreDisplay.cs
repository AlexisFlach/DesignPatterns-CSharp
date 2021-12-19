namespace observerpattern
{
    public class CurrentScoreDisplay : IObserver, IDisplayElement
    {
        private int HomeScore = 0;
        private int AwayScore = 0;

        private ILiveScore _liveScore;

        public CurrentScoreDisplay(ILiveScore liveScore)
        {
            _liveScore = liveScore;
            liveScore.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine("Current Score is " + HomeScore + "-" + AwayScore);
        }

        public void Update(int homeScore, int awayScore)
        {   
            System.Console.WriteLine("Updateds");
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
            Display();
        }
    }
}