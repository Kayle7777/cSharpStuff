using System;
using Xunit;
using MathStuff;

namespace MathTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TestMath math = new TestMath();
            Assert.Equal(4, math.Add(3, 1));
            Assert.Equal(120, math.Factorial(5));
            Assert.Equal(false, math.Prime(10));
        }
    }
}
