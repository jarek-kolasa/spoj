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
    public class DodawanieLiczbCalkowitychTests
    {
        [TestMethod()]
        public void LiczbyCalkowiteTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void OneHundredMinusSixtyEightAndTwelveGivesFortyFourTest()
        {
            int a = 100, b = -68, c = 12;
            int answer = 44;
            DodawanieLiczbCalkowitych dodawanie = new DodawanieLiczbCalkowitych();
            Assert.AreEqual(answer, dodawanie.LiczbyCalkowite(a,b,c));
        }
    }
}