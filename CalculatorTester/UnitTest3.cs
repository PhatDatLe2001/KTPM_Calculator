using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace CalculatorTester
{
    /// <summary>
    /// Summary description for UnitTest3
    /// </summary>
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix()
        {
            Radix radix;
            int number = 0;
            radix = new Radix(number);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void T2()
        {
            int number = 6;
            Radix radix = new Radix(number);
            int r = 1;
            radix.ConvertDecimalToAnother(r);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void T3()
        {
            int number = 6;
            Radix radix = new Radix(number);
            int r = 17;
            radix.ConvertDecimalToAnother(r);
        }
    }
}
