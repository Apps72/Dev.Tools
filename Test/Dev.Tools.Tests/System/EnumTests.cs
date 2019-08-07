using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model = System.ComponentModel;
using Apps72.Dev.Tools.System;

namespace Dev.Tools.Tests.System
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void Enum_GetDescription()
        {
            Assert.AreEqual("Description_1", MyEnum.Item1.GetDescription());
        }

        [TestMethod]
        public void Enum_GetUnknownDescription()
        {
            Assert.AreEqual(null, MyEnum.Item2.GetDescription());
        }

        private enum MyEnum
        {
            [Model.Description("Description_1")]
            Item1,

            Item2
        }
    }
}
