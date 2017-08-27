using NetStandard2AssertException;
using System;
using Xunit;

namespace NetStandard2AssertExceptionXUnitTest
{
    public class TestSample
    {
        [Fact]
        public void TestFoo()
        {
            var s = new Sample();
            s.Foo();
        }
    }
}
