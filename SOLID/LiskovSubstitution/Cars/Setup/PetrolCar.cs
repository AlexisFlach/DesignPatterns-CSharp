namespace LiskovSubstitution.Cars.Setup
{
    public class PetrolCar : Vehicle
    {
        private static int FUEL_TANK_FULL = 100;
        private int fuelTankLevel = 0;
        public override void FillUpWithFuel()
        {
            this.fuelTankLevel = FUEL_TANK_FULL;
        }

        public override void ChargeBattery()
        {
            throw new NotImplementedException();
        }
    }
}