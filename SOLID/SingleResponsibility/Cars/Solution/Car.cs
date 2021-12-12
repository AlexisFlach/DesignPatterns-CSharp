using System;

namespace SingleResponsibility.Cars.Solution
{   
    public class Car
    {
        public void Start() {
            System.Console.WriteLine("The car is starting!!");
        }
        public void Stop() {
            System.Console.WriteLine("The car is stopping!!");
        }
        public int GetOil() {
           return -1;
        }
    }

    public class Driver {
        public void Drive() => Console.WriteLine("I am driving!!");
    }

    public class CarWash {
        public void Wash(Car car) => Console.WriteLine("I am washing the" + car);
    }

    public class Mechanic {
        public void ChangeTires(Car car, Tire tire) {
            Console.WriteLine( $"I am changing the {tire} tires on the car {car}");
        }
    }

    public enum Tire {
        Michelin,
        Continental,
        Pirelli
    }
}