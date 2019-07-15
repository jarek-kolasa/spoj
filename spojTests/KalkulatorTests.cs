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
    public class KalkulatorTests
    {
        private Kalkulator kalkulator;

        [TestInitialize]
        public void Initialize()
        {
            kalkulator = new Kalkulator();
        }

        [TestMethod()]
        public void CalculateTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddSevenAndNineTest()
        {
            string input = "+ 7 9";
            Assert.AreEqual(16, kalkulator.Calculate(input));
        }

        [TestMethod()]
        public void ZeroMinusFourTest()
        {
            string input = "- 0 4";
            Assert.AreEqual(-4, kalkulator.Calculate(input));
        }

        [TestMethod()]
        public void MultiplyFiveAndSixTest()
        {
            string input = "* 5 6";
            Assert.AreEqual(30, kalkulator.Calculate(input));
        }

        [TestMethod()]
        public void DivisionEightAndThreeTest()
        {
            string input = "/ 8 3";
            Assert.AreEqual(2, kalkulator.Calculate(input));
        }

        [TestMethod()]
        public void ModFiveAndTwoTest()
        {
            string input = "% 5 2";
            Assert.AreEqual(1, kalkulator.Calculate(input));
        }
    }
}