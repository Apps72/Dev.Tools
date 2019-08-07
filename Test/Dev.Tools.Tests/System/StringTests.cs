using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Apps72.Dev.Tools.System;

namespace Dev.Tools.Tests.System
{
    [TestClass]
    public class ForEachTests
    {
        [TestMethod]
        public void String_IsEmpty()
        {
            string x = "";
            string y = null;
            string z = "abc";

            Assert.AreEqual(true, x.IsEmpty());
            Assert.AreEqual(true, y.IsEmpty());
            Assert.AreEqual(false, z.IsEmpty());
        }

        [TestMethod]
        public void String_IsNotEmpty()
        {
            string x = "";
            string y = null;
            string z = "abc";

            Assert.AreEqual(false, x.IsNotEmpty());
            Assert.AreEqual(false, y.IsNotEmpty());
            Assert.AreEqual(true, z.IsNotEmpty());
        }
    }
}
