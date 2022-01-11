using Xunit;

namespace DuckSim.Tests;

public class DuckTest
{
    [Fact]
    public void ValidMallardDuck()
    {   
   
        MallardDuck mallardDuck = new MallardDuck();

        string expect = "Flying";

        string actual = mallardDuck.PerformFly();

        Assert.Equal(expect, actual);
    }
    [Fact]
    public void SetNewFlyBehavior()
    {   

        MallardDuck mallardDuck = new MallardDuck();
        mallardDuck.SetNewFlyBehavior(new FlyNoWay());

        string expect = "I can't fly";

        string actual = mallardDuck.PerformFly();

        Assert.Equal(expect, actual);
    }
}