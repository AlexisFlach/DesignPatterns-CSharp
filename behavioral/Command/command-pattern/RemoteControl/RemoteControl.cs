using System.Text;

namespace RemoteControl
{
    public class RemoteControl
    {
        ICommand[] OnCommands;
        ICommand[] OffCommands;
        ICommand UndoCommand;

        NoCommand NoCommand;

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            NoCommand = new NoCommand();

            for(int i = 0; i < 7; i++) {
               OnCommands[i] = NoCommand;
               OffCommands[i] = NoCommand;
           }

           UndoCommand = NoCommand;

        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) {
                OnCommands[slot] = onCommand;
                OffCommands[slot] = offCommand;
            }

            public void OnButtonWasPushed(int slot) {
                if(OnCommands[slot] != null) {
                OnCommands[slot].Execute();
                UndoCommand = OnCommands[slot];
                }
            }
            public void OffButtonWasPushed(int slot) {
                if(OnCommands[slot] != null) {
                OffCommands[slot].Execute();
                UndoCommand = OnCommands[slot];
                }
            }   


            public void UndoButtonWasPressed(int slot) {
                UndoCommand.Undo();
            }

            public override String ToString() {
                StringBuilder str = new StringBuilder(); 
                for(var i = 0; i < OnCommands.Count(); i++) {
                    str.Append("slot " + i + " " + OnCommands[i].NameOf() + " " + OffCommands[i].NameOf() + "\n");
                }
                return str.ToString();

            }
    }
}