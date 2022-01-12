using Xunit;

namespace Cafe.Tests
{

    public class BeverageTest
    {
        [Fact]
        public void TestEspressoWithoutCondiment()
        {
            Beverage beverage = new Espresso();

            string expected = "Espresso";

            string actual = beverage.GetDescription();

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestEspressoWithCondiment()
        {
            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);

            string expect = "Espresso, Mocha";

            string actual = beverage2.GetDescription();

            Assert.Equal(expect, actual);
        }
        [Fact]
        public void TestEspressoCostWithCondiment()
        {
            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);

            double expect = 2.89;

            double actual = beverage2.Cost();

            Assert.Equal(expect, actual);
        }
    }
}