namespace LiskovSubstitution.Cars.Setup
{
    public class Cars
    {
        public static void Run() {
            FillingStation fillStation = new FillingStation();
            PetrolCar petrolCar = new PetrolCar();
            ElectricCar electricCar = new ElectricCar();
            fillStation.charge(electricCar);
            fillStation.refuel(petrolCar);
        }
    }
}