using NUnit.Framework;

namespace Exercise_04.RomanNumeral
{
    [TestFixture]
    public class Tests
    {
        RomanNumeral rn;
        RomanNumeral an;

        [SetUp]
        public void Setup()
        {
            rn = new RomanNumeral();
            an = new RomanNumeral();
        }

        [Test]
        public void Test1_Zero()
        {
            Assert.AreEqual("", rn.ArabicToRoman(0));
        }
        [Test]
        public void Test2_One()
        {
            Assert.AreEqual("I", rn.ArabicToRoman(1));
        }
        [Test]
        public void Test3_Three()
        {
            Assert.AreEqual("III", rn.ArabicToRoman(3));
        }
        [Test]
        public void Test4_Four()
        {
            Assert.AreEqual("IV", rn.ArabicToRoman(4));
        }
        [Test]
        public void Test5_Five()
        {
            Assert.AreEqual("V", rn.ArabicToRoman(5));
        }
        [Test]
        public void Test6_Six()
        {
            Assert.AreEqual("VI", rn.ArabicToRoman(6));
        }
        [Test]
        public void Test7_Nine()
        {
            Assert.AreEqual("IX", rn.ArabicToRoman(9));
        }
        [Test]
        public void Test8_Ten()
        {
            Assert.AreEqual("X", rn.ArabicToRoman(10));
        }
        [Test]
        public void Test9_Twenty()
        {
            Assert.AreEqual("XXIV", rn.ArabicToRoman(24));
        }
        [Test]
        public void Test10_TheertyEigth()
        {
            Assert.AreEqual("XXXVIII", rn.ArabicToRoman(38));
        }
        [Test]
        public void Test11_FourtyTwo()
        {
            Assert.AreEqual("XLII", rn.ArabicToRoman(42));
        }
        [Test]
        public void Test12_FiftyOne()
        {
            Assert.AreEqual("LI", rn.ArabicToRoman(51));
        }
        [Test]
        public void Test13_NinetyFive()
        {
            Assert.AreEqual("XCV", rn.ArabicToRoman(95));
        }
        [Test]
        public void Test14_104()
        {
            Assert.AreEqual("CIV", rn.ArabicToRoman(104));
        }
        [Test]
        public void Test15_419()
        {
            Assert.AreEqual("CDXIX", rn.ArabicToRoman(419));
        }
        [Test]
        public void Test16_555()
        {
            Assert.AreEqual("DLV", rn.ArabicToRoman(555));
        }
        [Test]
        public void Test17_986()
        {
            Assert.AreEqual("CMLXXXVI", rn.ArabicToRoman(986));
        }
        [Test]
        public void Test18_1499()
        {
            Assert.AreEqual("MCDXCIX", rn.ArabicToRoman(1499));
        }
        [Test]
        public void Test19_2219()
        {
            Assert.AreEqual("MMCCXIX", rn.ArabicToRoman(2219));
        }
        [Test]
        public void Test20_Fail()
        {
            Assert.AreNotEqual("MMXVIII", rn.ArabicToRoman(2017));
        }
        [Test]
        public void Test27_Empty()
        {
            Assert.AreEqual(0, an.RomanToArabic(""));
        }
        [Test]
        public void Test23_One()
        {
            Assert.AreEqual(1, an.RomanToArabic("I"));
        }
        [Test]
        public void Test24_9()
        {
            Assert.AreEqual(9, an.RomanToArabic("IX"));
        }
        [Test]
        public void Test26_94()
        {
            Assert.AreEqual(94, an.RomanToArabic("XCIV"));
        }
        [Test]
        public void Test25_943()
        {
            Assert.AreEqual(943, an.RomanToArabic("CMXLIII"));
        }
        [Test]
        public void Test21_1499()
        {
            Assert.AreEqual(1499, an.RomanToArabic("MCDXCIX"));
        }
        [Test]
        public void Test22_3806()
        {
            Assert.AreEqual(3806, an.RomanToArabic("MMMDCCCVI"));
        }
    }
}