using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Apps72.Dev.Tools.Linq;
using System.Collections.Generic;

namespace Dev.Tools.Tests.Linq
{
    [TestClass]
    public class ForEachTests
    {
        [TestMethod]
        public void ForEach_Normal()
        {
            var data = new[] { 1, 3, 5 };
            var results = new List<int>();

            data.ForEach(x => results.Add(x));

            Assert.AreEqual(1, results[0]);
            Assert.AreEqual(3, results[1]);
            Assert.AreEqual(5, results[2]);
        }

        [TestMethod]
        public void ForEach_Indexed()
        {
            var data = new[] { 1, 3, 5 };
            var results = new List<int>();

            data.ForEach((x, index) => results.Add(index));

            Assert.AreEqual(0, results[0]);
            Assert.AreEqual(1, results[1]);
            Assert.AreEqual(2, results[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ForEach_SourceNull()
        {
            IEnumerable<int> data = null;
            var results = new List<int>();

            data.ForEach(x => results.Add(x));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ForEach_ActionNull()
        {
            IEnumerable<int> data = new[] { 1, 3, 5 };
            Action<int> action = null;
            var results = new List<int>();

            data.ForEach(action);
        }
    }
}
