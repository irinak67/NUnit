using NUnit.Framework;

namespace Exercise_3.Calculator
{
    [TestFixture]
    public class Tests
    {
        Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Test1_Empty()
        {
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test2_Three()
        {
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test3_One()
        {
            calc.Press("1");
            string result = calc.GetDisplay();
            Assert.AreEqual("1", result);
        }
        [Test]
        public void Test4_TwoNumbers()
        {
            calc.Press("2");
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("23", result);
        }
        [Test]
        public void Test5_ZeroAndNumber()
        {
            calc.Press("0");
            calc.Press("3");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test6_FourZeroAndNumber()
        {
            calc.Press("0");
            calc.Press("0");
            calc.Press("0");
            calc.Press("0");
            calc.Press("5");
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test7_NumberAndOperation()
        {
            calc.Press("3");
            calc.Press("+");            
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test8_NumberAndOperation()
        {
            calc.Press("3");
            calc.Press("/");
            string result = calc.GetDisplay();
            Assert.AreEqual("3", result);
        }
        [Test]
        public void Test9_SumWithoutEqual()
        {
            calc.Press("3");
            calc.Press("+");
            calc.Press("2");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test10_ResetAfterNumbers()
        {
            calc.Press("1");
            calc.Press("2");
            calc.Press("3");
            calc.Press("C");
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test11_Reset()
        {
            calc.Press("C");            
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test12_OperationWithEqual()
        {
            calc.Press("4");
            calc.Press("-");
            calc.Press("2");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test13_OperationWithEqual()
        {
            calc.Press("5");
            calc.Press("+");
            calc.Press("1");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("6", result);
        }
        [Test]
        public void Test14_OperationWithEqual()
        {
            calc.Press("3");
            calc.Press("-");
            calc.Press("5");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("-2", result);
        }
        [Test]
        public void Test15_Absolut()
        {           
            calc.Press("-");
            calc.Press("2");            
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test16_DivByZero()
        {
            calc.Press("4");
            calc.Press("/");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("E", result);
        }
        [Test]
        public void Test17_MultiByZero()
        {
            calc.Press("3");
            calc.Press("*");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("0", result);
        }
        [Test]
        public void Test18_division()
        {
            calc.Press("13");
            calc.Press("/");
            calc.Press("5");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("2", result);
        }
        [Test]
        public void Test19_BigNumber()
        {
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            calc.Press("1");
            string result = calc.GetDisplay();
            Assert.AreEqual("11111", result);
        }
        [Test]
        public void Test20_BigNumber()
        {
            calc.Press("1");
            calc.Press("2");
            calc.Press("3");
            calc.Press("4");
            calc.Press("5");
            calc.Press("6");
            string result = calc.GetDisplay();
            Assert.AreEqual("23456", result);
        }
        [Test]
        public void Test21_BigNumber()
        {
            calc.Press("9");
            calc.Press("9");
            calc.Press("9");
            calc.Press("9");
            calc.Press("+");
            calc.Press("1");
            calc.Press("0");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("E", result);
        }
        [Test]
        public void Test22_Exercise()
        {
            calc.Press("3");
            calc.Press("+");
            calc.Press("4");
            calc.Press("*");
            calc.Press("8");            
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("56", result);
        }
        [Test]
        public void Test23_Exercise()
        {
            calc.Press("1");
            calc.Press("+");
            calc.Press("3");
            calc.Press("=");
            calc.Press("5");            
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test24_Exercise()
        {
            calc.Press("1");
            calc.Press("+");
            calc.Press("-");
            calc.Press("3");
            calc.Press("=");
            string result = calc.GetDisplay();
            Assert.AreEqual("-2", result);
        }
        [Test]
        public void Test25_String()
        {
            calc.Press("1+3=5");            
            string result = calc.GetDisplay();
            Assert.AreEqual("5", result);
        }
        [Test]
        public void Test26_String()
        {
            calc.Press("DELETE TABLE FROM");
            string result = calc.GetDisplay();
            Assert.AreEqual(" FROM", result);
        }
        [Test]
        public void Test27_String()
        {
            calc.Press("D");
            string result = calc.GetDisplay();
            Assert.AreEqual("D", result);
        }
    }
}