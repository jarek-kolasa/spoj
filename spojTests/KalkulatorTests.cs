using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            kalkulator.Calculate(input);
            Assert.AreEqual(16, kalkulator.GetResult());
        }

        [TestMethod()]
        public void ZeroMinusFourTest()
        {
            string input = "- 0 4";
            kalkulator.Calculate(input);
            Assert.AreEqual(-4, kalkulator.GetResult());
        }

        [TestMethod()]
        public void MultiplyFiveAndSixTest()
        {
            string input = "* 5 6";
            kalkulator.Calculate(input);
            Assert.AreEqual(30, kalkulator.GetResult());
        }

        [TestMethod()]
        public void DivisionEightAndThreeTest()
        {
            string input = "/ 8 3";
            kalkulator.Calculate(input);
            Assert.AreEqual(2, kalkulator.GetResult());
        }

        [TestMethod()]
        public void ModFiveAndTwoTest()
        {
            string input = "% 5 2";
            kalkulator.Calculate(input);
            Assert.AreEqual(1, kalkulator.GetResult());
        }
    }
}