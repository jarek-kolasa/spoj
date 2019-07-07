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
    public class NowaDzialkaTests
    {
        [TestMethod()]
        public void GetAreaTestReturnsTrue()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void FiveGivesTwentyFiveTest()
        {
            int dimension = 5;
            NowaDzialka dzialka = new NowaDzialka();
            Assert.AreEqual(25, dzialka.GetArea(dimension));
        }

        [TestMethod()]
        public void ThreeGivesNineTest()
        {
            int dimension = 3;
            NowaDzialka dzialka = new NowaDzialka();
            Assert.AreEqual(9, dzialka.GetArea(dimension));
        }
    }
}