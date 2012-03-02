using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using m;

namespace m.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMethod1()
        {
            var program = new Program();

            Assert.IsTrue(program.Hello() == "Hello");
        }
    }
}
