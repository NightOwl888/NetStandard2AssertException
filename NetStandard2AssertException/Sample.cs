using System;
using System.Diagnostics;

namespace NetStandard2AssertException
{
    public class Sample
    {
        public void Foo()
        {
            Debug.Assert(false);
        }
    }
}
