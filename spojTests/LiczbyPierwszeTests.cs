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
            int testsQuantity = 3;
            int [] inputValues = { 11, 1, 4};
            string [] answers = { "TAK", "NIE", "NIE"};
            LiczbyPierwsze liczby = new LiczbyPierwsze(testsQuantity, inputValues);

            Assert.AreEqual(answers[0], liczby.GetAnswer()[0]);
            Assert.AreEqual(answers[1], liczby.GetAnswer()[1]);
            Assert.AreEqual(answers[2], liczby.GetAnswer()[2]);
        }
    }
}