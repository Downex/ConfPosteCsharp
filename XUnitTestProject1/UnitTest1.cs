using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            int a = 5;
            int b = 10;

            Assert.Equal(15, a + b);
        }
    }
}
