namespace Adapter
{
    public class TurkeyAdapter : IDuck
    {   
        ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey) 
        {
            _turkey = turkey;
        }
        public void Fly()
        {
            for(int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}