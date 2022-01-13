namespace RemoteControl
{
    public class LightonCommand : ICommand
    {
        Light light;

        public LightonCommand(Light light)
        {
         this.light = light;   
        }
        public void Execute() {
            light.On();
        }
        public void Undo() {
            light.Off();
        }
    }
}