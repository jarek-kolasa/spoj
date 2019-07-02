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
    public class PrzedszkolankaTests
    {
        [TestMethod()]
        public void PrzedszkolankaTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void twelveAndFifteenShouldGiveSixtyTest()
        {
            string inputText = "12 15";
            int output = 60;

            Przedszkolanka przedszkolanka = new Przedszkolanka();

            Assert.AreEqual(output, przedszkolanka.BringSweets(inputText));
        }

        [TestMethod()]
        public void elevenAndTwentyTwoShouldGiveTwentyTwoTest()
        {
            string inputText = "11 22";
            int output = 22;

            Przedszkolanka przedszkolanka = new Przedszkolanka();

            Assert.AreEqual(output, przedszkolanka.BringSweets(inputText));
        }
    }
}