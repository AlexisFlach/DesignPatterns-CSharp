namespace SingleResponsibility.Cars.Setup
{
    public class Setup
    {

    }
    public abstract class Car
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void ChangeTires(Tire tire);
        public abstract void Drive();
        public abstract void Wash();
        public abstract void CheckOil();
        public abstract int GetOil();
    }
    public enum Tire
    {
        Michelin,
        Continental,
        Pirelli
    }
}