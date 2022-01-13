namespace RemoteControl
{   
    public enum LightStates {
        ON,
        OFF
    }
    public class Light
    {
        public LightStates state = LightStates.OFF;
        public void On() => state = LightStates.ON;
         public void Off() => state = LightStates.OFF;
        
    }
}