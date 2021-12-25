namespace RemoteControl
{
    public class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
         this.light = light;   
        }
        public void Execute() {
            light.Off();
        }
        public void Undo() {
            light.On();
        }
    }
}