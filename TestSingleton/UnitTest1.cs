using System;
using Xunit;
using Singleton;

namespace TestSingleton
{
    public class UnitTest1
    {
        [Fact]
        public void Test_GetCounter()
        {
            
            Assert.Equal(0, Counter.Getinstance.Display());



        }
    }
}