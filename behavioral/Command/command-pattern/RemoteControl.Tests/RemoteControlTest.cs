using Xunit;

namespace RemoteControl.Tests
{

    public class RemoteControlTest
    {

        [Fact]
        public void TestTurnOnLight()
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            LightonCommand lightOn = new LightonCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            remote.SetCommand(0, lightOn, lightOff);
            remote.OnButtonWasPushed(0);

            LightStates expect = LightStates.ON;

            LightStates actual = light.state;

            Assert.Equal(expect, actual);

            // remote.UndoButtonWasPressed(0);
        }
        [Fact]
        public void TestTurnOnAndOffLight()
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            LightonCommand lightOn = new LightonCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            remote.SetCommand(0, lightOn, lightOff);
            remote.OnButtonWasPushed(0);
            remote.UndoButtonWasPressed(0);

            LightStates expect = LightStates.OFF;

            LightStates actual = light.state;

            Assert.Equal(expect, actual);
        }
    }
}