namespace observerpattern
{
    public interface IObserver
    {
         void Update(int homeScore, int awayScore);
    }
}