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
    public class LiczbyPierwszeTests
    {
        [TestMethod()]
        public void TestShouldPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Value3ShouldGiveTakAnswer()
        {
            int inputValue = 3;
            string answer = "TAK";
            LiczbyPierwsze liczby = new LiczbyPierwsze(inputValue, answer);

            Assert.AreEqual(answer, liczby.GetAnswer());
        }

    }
}