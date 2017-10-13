using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyBusinessClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyBusinessClassLibrary.Tests
{
    [TestClass()]
    public class clsMonkeyBusinessTests
    {
        [TestMethod()]
        public void XingMonkeysTest()
        {
            var cls = new clsMonkeyBusiness();

            // Use this to test the response with the dynamic parameters
            var objResponse = cls.XingMonkeys(10, 5);

            Assert.Fail();
        }
    }
}