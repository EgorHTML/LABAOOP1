using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Tests
{
    [TestClass()]
    public class RationalNumberTests
    {
        [TestMethod()]
        public void TestAddition()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            var result = a + b;
            Assert.AreEqual(new RationalNumber(5, 6), result);
        }

        [TestMethod()]
        public void TestSubtraction()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            var result = a - b;
            Assert.AreEqual(new RationalNumber(1, 6), result);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 2);
            Assert.AreEqual(a, b);
        }

        [TestMethod()]
        public void NotEqualsTest()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            Assert.AreNotEqual(a, b);
        }

        [TestMethod()]
        public void OverTest()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            Assert.IsTrue(a > b);
        }

        [TestMethod()]
        public void LessTest()
        {
            var a = new RationalNumber(1, 4);
            var b = new RationalNumber(1, 3);
            Assert.IsTrue(a < b);
        }
    }
}