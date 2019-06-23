using Microsoft.VisualStudio.TestTools.UnitTesting;
using spoj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.Tests
{
    [TestClass()]
    public class NWDTests
    {
        [TestMethod()]
        public void GreatestCommonDivisorTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void FiveTests()
        {
            int tests = 5;
            string[] testsExamples = new string[] { "1 4", "4 1", "12 48", "48 100", "123456 653421"};
            NWD nwd = new NWD(tests, testsExamples);
            Assert.AreEqual(1, nwd.GetDeivsors()[0]);
            Assert.AreEqual(1, nwd.GetDeivsors()[1]);
            Assert.AreEqual(12, nwd.GetDeivsors()[2]);
            Assert.AreEqual(4, nwd.GetDeivsors()[3]);
            Assert.AreEqual(3, nwd.GetDeivsors()[4]);
        }
    }
}