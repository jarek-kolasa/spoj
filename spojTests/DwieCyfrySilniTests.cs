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
    public class DwieCyfrySilniTests
    {
        [TestMethod()]
        public void DwieCyfrySilniTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Number1Gives01Test()
        {
            int testsQuantity = 1;
            int[] numbers = { 1 };

            DwieCyfrySilni cyfrySilni = new DwieCyfrySilni();

            Assert.AreEqual("0 1", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[0]);
        }

        [TestMethod()]
        public void Number4Gives24Test()
        {
            int testsQuantity = 1;
            int[] numbers = { 4 };

            DwieCyfrySilni cyfrySilni = new DwieCyfrySilni();

            Assert.AreEqual("2 4", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[0]);
        }

        [TestMethod()]
        public void Numbers1and4Gives01and24Test()
        {
            int testsQuantity = 2;
            int[] numbers = { 1, 4 };

            DwieCyfrySilni cyfrySilni = new DwieCyfrySilni();

            Assert.AreEqual("0 1", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[0]);
            Assert.AreEqual("2 4", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[1]);
        }

        [TestMethod()]
        public void MultiplyNumbersTest()
        {
            int testsQuantity = 3;
            int[] numbers = { -1, 0, 10 };

            DwieCyfrySilni cyfrySilni = new DwieCyfrySilni();

            Assert.AreEqual("0 0", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[0]);
            Assert.AreEqual("0 0", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[1]);
            Assert.AreEqual("0 0", cyfrySilni.DwieCyfrySilniSpoj(testsQuantity, numbers)[2]);
        }
    }
}