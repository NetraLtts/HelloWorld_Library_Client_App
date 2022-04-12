using System;
using Xunit;
using McMathLib;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Assert.True(true);

        }

        [Fact]

        public void Test2()
        {
            MathClass math = new MathClass();
            double result = math.Calculate(10,20,"Add");

            Assert.Equal(result, 30);
            
        }
    }
}
