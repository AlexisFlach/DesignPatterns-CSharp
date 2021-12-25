using RemoteControl;

// SimpleRemoteControl remote = new SimpleRemoteControl();
SuperRemoteControl remote = new SuperRemoteControl();
Light light = new Light();
LightonCommand lightOn = new LightonCommand(light);
LightOffCommand lightOff = new LightOffCommand(light);
remote.SetCommand(0, lightOn, lightOff);
System.Console.WriteLine(remote);
remote.OnButtonWasPushed(0);  
remote.UndoButtonWasPressed(0);
