using NetStandard2AssertException;
using NUnit.Framework;
using System;

namespace NetStandard2AssertExceptionTest
{
    public class TestSample
    {
        [Test]
        public void TestFoo()
        {
            var s = new Sample();
            s.Foo();
        }
    }
}
