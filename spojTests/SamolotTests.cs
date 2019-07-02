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
    public class SamolotTests
    {
        [TestMethod()]
        public void GetSitsTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Get70SitsTest()
        {
            string text = "2 5 3 20";
            int output = 70;

            Samolot samolot = new Samolot();

            Assert.AreEqual(output, samolot.GetSits(text));
        }
    }
}