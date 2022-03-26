using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        public TestContext TestContext { get; set; }
        [TestInitialize]//Thiết lập dữ liệu dùng chung cho test case
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]//Test case
        public void TestAddOperator()
        {
            int expected, actual;//expected kết quả mong đợi
                                 //actual kết quả thực tế
            expected = 15;
            actual = cal.Execute("+");
            Assert.AreEqual(actual, expected);
        }//Test case a=10, b=5, =15
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        [TestMethod]
        public void TestDivRound()
        {
            Calculation c = new Calculation(5, 2);
            Assert.AreEqual(c.Execute("/"), 2);
        }

        //Liên kết TestData với project
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string oparation = TestContext.DataRow[2].ToString();
            oparation = oparation.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute(oparation);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\PowerTestData.csv", "PowerTestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPower()
        {
            int n;
            double x, expected;
            n = int.Parse(TestContext.DataRow[1].ToString());
            x = double.Parse(TestContext.DataRow[0].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString()); ;
            double actual;
            actual = Cau1.Power(x, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
