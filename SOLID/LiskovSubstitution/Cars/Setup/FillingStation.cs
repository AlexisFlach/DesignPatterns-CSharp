namespace LiskovSubstitution.Cars.Setup
{
    public class FillingStation
    {

        public void refuel(Vehicle vehicle)
        {
            if (typeof(PetrolCar).IsInstanceOfType(vehicle))
            {   
                System.Console.WriteLine("Filling up " + vehicle + "with fuel");
                vehicle.FillUpWithFuel();
            }
        }
        public void charge(Vehicle vehicle)
        {
            if (typeof(ElectricCar).IsInstanceOfType(vehicle))
            {   
                System.Console.WriteLine("Charging up " + vehicle);
                vehicle.ChargeBattery();
            }
        }
    }
}