namespace LiskovSubstitution.Cars.Setup
{
    public abstract class Vehicle {

    private bool EngineStarted = false;

    public void StartEngine() {
        this.EngineStarted = true;
    }

    public bool EngineIsStarted() {
        return EngineStarted;
    }
    public void StopEngine() {
        this.EngineStarted = false;
    }
    public abstract void FillUpWithFuel();

    public abstract void ChargeBattery();

}

}