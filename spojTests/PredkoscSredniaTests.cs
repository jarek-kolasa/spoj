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
    public class PredkoscSredniaTests
    {
        [TestMethod()]
        public void ReturnTrueTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AverageSpeed5050ShouldGive50Test()
        {
            string inputSpeed = "50 50"; 
            int vavrg = 50;
            PredkoscSrednia predkosc = new PredkoscSrednia(inputSpeed);
            Assert.AreEqual(vavrg, predkosc.GetAverageSpeed());
        }

        [TestMethod()]
        public void AverageSpeed4060ShouldGive48Test()
        {
            string inputSpeed = "40 60";
            int vavrg = 48;
            PredkoscSrednia predkosc = new PredkoscSrednia(inputSpeed);
            Assert.AreEqual(vavrg, predkosc.GetAverageSpeed());
        }
    }
}