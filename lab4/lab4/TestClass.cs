using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab4
{
    [TestFixture]
    class TestClass
    {

        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Triangle.isExist(3, 5, 3));
            Assert.IsTrue(Triangle.isExist(153, 175, 123));
            Assert.IsTrue(Triangle.isExist(9958, 10255, 7363));
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsFalse(Triangle.isExist(4, 7, 20));
            Assert.IsFalse(Triangle.isExist(13, 7562, 128));
            Assert.IsFalse(Triangle.isExist(859, 56445, 10));
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Triangle.isExist(3, 3, 3));
            Assert.AreEqual(true, Triangle.isExist(185, 139, 153));
            Assert.AreEqual(true, Triangle.isExist(5896, 6485, 5479));
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(false, Triangle.isExist(1, 2, 4));
            Assert.AreEqual(false, Triangle.isExist(1235, 2545, 4445));
            Assert.AreEqual(false, Triangle.isExist(656565, 5646455, 545555));
        }

        [Test]
        public void TestMethod5()
        {
            Assert.Throws<Exception>(() => Triangle.isExist(-1, 2, 2));
            Assert.Throws<Exception>(() => Triangle.isExist(12, -15, 18));
            Assert.Throws<Exception>(() => Triangle.isExist(125, 153, -145));
            Assert.Throws<Exception>(() => Triangle.isExist(10, -12, -14));
            Assert.Throws<Exception>(() => Triangle.isExist(-10, 12, -14));
            Assert.Throws<Exception>(() => Triangle.isExist(-10, -12, 14));
            Assert.Throws<Exception>(() => Triangle.isExist(-10, -12, -14));
        }

        [Test]
        public void TestMethod6()
        {
            Assert.IsTrue(Triangle.isExist(4.5, 7.234567877845, 4.9673543578));
            Assert.IsTrue(Triangle.isExist(158.4455456654, 172.54546455, 148.96734645));
        }

        [Test]
        public void TestMethod7()
        {
            Assert.IsTrue(Triangle.isExist((Convert.ToDouble("14,44")), 15.25, 12.23));
            Assert.IsTrue(Triangle.isExist(14.44, Convert.ToDouble("15,25"), 12.23));
            Assert.IsTrue(Triangle.isExist(14.44, 15.25, Convert.ToDouble("12,23")));
            Assert.IsTrue(Triangle.isExist(14.44, Convert.ToDouble("15,25"), Convert.ToDouble("12,23")));
            Assert.IsTrue(Triangle.isExist(Convert.ToDouble("14,44"), Convert.ToDouble("15,25"), 12.23));
            Assert.IsTrue(Triangle.isExist(Convert.ToDouble("14,44"), 15.25, Convert.ToDouble("12,23")));
            Assert.IsTrue(Triangle.isExist(Convert.ToDouble("14,44"), Convert.ToDouble("15,25"), Convert.ToDouble("12,23")));
        }

        [Test]
        public void TestMethod8()
        {
            Assert.IsTrue(Triangle.isExist(Double.MaxValue, Double.MaxValue, Double.MaxValue));
            Assert.IsTrue(Triangle.isExist(int.MaxValue, int.MaxValue, int.MaxValue));
            Assert.IsTrue(Triangle.isExist(Int16.MaxValue, Int16.MaxValue, Int16.MaxValue));
            Assert.IsTrue(Triangle.isExist(Int32.MaxValue - 10, Int32.MaxValue -10 , Int32.MaxValue-10));
        }

        [Test]
        public void TestMethod9()
        {
            Assert.IsTrue(Triangle.isExist(4 + 7 + 20, 7 + 4 + 20, 20.0 + 4.0 + 7.0));
            Assert.IsTrue(Triangle.isExist(10*3/2 ,7*20/(5*2), 15-2 ));
        }

        [Test]
        public void TestMethod10()
        {
            Assert.Throws<Exception>(() => Triangle.isExist(0, 2, 2));
            Assert.Throws<Exception>(() => Triangle.isExist(2, 0, 2));
            Assert.Throws<Exception>(() => Triangle.isExist(2, 2, 0));
            Assert.Throws<Exception>(() => Triangle.isExist(0, 0, 2));
            Assert.Throws<Exception>(() => Triangle.isExist(0, 2, 0));
            Assert.Throws<Exception>(() => Triangle.isExist(2, 0, 0));
            Assert.Throws<Exception>(() => Triangle.isExist(0, 0, 0));

        }
    }
}
