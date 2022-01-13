namespace RemoteControl
{
    public class LightOffCommand : ICommand
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