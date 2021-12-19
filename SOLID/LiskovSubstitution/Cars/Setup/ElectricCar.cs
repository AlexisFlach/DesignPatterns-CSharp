namespace LiskovSubstitution.Cars.Setup
{
    public class ElectricCar : Vehicle
    {
        private static int BATTERY_FULL = 100;
        private int batteryLevel;
        public override void FillUpWithFuel()
        {
            throw new NotImplementedException();
        }
        public override void ChargeBattery()
        {
            batteryLevel = BATTERY_FULL;
        }

        public int BatteryLevel() => batteryLevel;
    }
}