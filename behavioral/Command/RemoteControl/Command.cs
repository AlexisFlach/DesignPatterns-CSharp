namespace RemoteControl
{
    public interface Command
    {
        public void Execute();  
        public void Undo(); 
    }
}