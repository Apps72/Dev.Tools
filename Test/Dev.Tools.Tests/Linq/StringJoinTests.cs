using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Apps72.Dev.Tools.Linq;

namespace Dev.Tools.Tests.Linq
{
    [TestClass]
    public class StringJoinTests
    {
        [TestMethod]
        public void StringJoin_Normal()
        {
            var data = new[] { 1, 3, 5 };

            var results = data.StringJoin(", ");

            Assert.AreEqual("1, 3, 5", results);
        }
    }
}
