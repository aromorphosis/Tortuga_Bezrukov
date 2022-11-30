using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tortuga_Bezrukov;
using Tortuga_Bezrukov.ClassHelper;
using static Tortuga_Bezrukov.ClassHelper.CostDisc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCostBigger()
        {
            decimal cost = 10000;
            DateTime date = new DateTime(2022, 10, 29);
            decimal ex = 8900;
            decimal res = Tortuga_Bezrukov.ClassHelper.CostDisc.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }

        [TestMethod]
        public void TestCostSmaller()
        {
            decimal cost = 200;
            DateTime date = new DateTime(2022, 10, 29);
            decimal ex = 178;
            decimal res = Tortuga_Bezrukov.ClassHelper.CostDisc.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }

        [TestMethod]
        public void TestWrongDate()
        {
            decimal cost = 100;
            DateTime date = new DateTime(2022, 10, 28);
            decimal ex = 100;
            decimal res = Tortuga_Bezrukov.ClassHelper.CostDisc.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }
    }
}
