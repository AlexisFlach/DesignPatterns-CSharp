namespace observerpattern
{
    public class LiveScore : ILiveScore
    {   
        private readonly List<IObserver> _observers;
        private int HomeScore = 0;
        private int AwayScore = 0;

        public LiveScore()
        {
            _observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach(IObserver obs in _observers)
            {
                obs.Update(HomeScore, AwayScore);
            }
        }

        public void RegisterObserver(IObserver obs)
        {
            _observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            throw new NotImplementedException();
        }

        public void ResultChanged() {
            NotifyObservers();
        }

        public void SetResult(int awayScore, int homeScore)
        {
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
            ResultChanged();
        }
    }
}