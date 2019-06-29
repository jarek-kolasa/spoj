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
    public class TabliceTests
    {
        [TestMethod()]
        public void CalculateTabliceTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void WriteTest1()
        {
            string input = "7 1 2 3 4 5 6 7";
            string answer = "7 6 5 4 3 2 1";
            Tablice tablice = new Tablice();
            string output = (tablice.CalculateTablice(input));
            Assert.AreEqual(answer, output);
        }

        [TestMethod()]
        public void WriteTest2()
        {
            string input = "3 3 2 11";
            string answer = "11 2 3";
            Tablice tablice = new Tablice();
            string output = (tablice.CalculateTablice(input));
            Assert.AreEqual(answer, output);
        }
    }
}