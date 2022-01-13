namespace RemoteControl
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}