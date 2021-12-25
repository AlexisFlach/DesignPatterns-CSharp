namespace RemoteControl
{
    public class LightonCommand : Command
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