using Xunit;
using Unique;

namespace Unique.Tests
{

    public class SingletonTest
    {
        [Fact]
        public void TestSingletonInstances()
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Assert.True(singleton.Equals(singleton2));
        }
    }
}