using Xunit;
using FluentAssertions;
using GumballMachine;

namespace GumballMachine.Tests;

public class UnitTest1
{
    [Fact]
    public void InitialStateTest()
    {
        var gumballMachine = new GumballMachineClass(3);
    

        IState expect = new NoQuarterState(gumballMachine);

        IState actuall = gumballMachine.state;

        expect.Equals(actuall);
    }
    [Fact]
    public void InsertQuarterStateTest()
    {
        var gumballMachine = new GumballMachineClass(3);
        gumballMachine.InsertQuarter();

        IState actuall = gumballMachine.state;

        actuall.Should().BeOfType<HasQuarterState>();
    }
}