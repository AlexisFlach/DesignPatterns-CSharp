using static System.Console;

namespace IntefaceSegregation
{
    public interface IAnimal
    {
        void Bark();
        void Fly();
        void Swim();
    }

    public class Dog : IAnimal
    {
        public void Bark()
        {
            WriteLine("Bark!!");
        }
        public void Fly()
        {
            new NotImplementedException();
        }

        public void Swim()
        {
            WriteLine("Swim!!");
        }
    }
}