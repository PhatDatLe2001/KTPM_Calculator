using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTester
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestPolynomialT()
        {
            Polynomial p;
            int n = 2;
            List<int> a = new List<int>() { 1, 2, 3};
            p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolynomialF()
        {
            Polynomial p;
            int n = 2;
            List<int> a = new List<int>() { 1, 2 };
            p = new Polynomial(n, a);
        }
        [TestMethod]
        public void TestCal()
        {
            Polynomial p;
            int n = 2;
            int x = 1;
            int ex;
            List<int> a = new List<int>() {0,  1, 2 };
            p = new Polynomial(n, a);
            ex = 3;
            Assert.AreEqual(ex, p.Cal(x));
        }
    }
}
