
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_OnesComplement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_StringEmpty()
        {
            Assert.AreEqual(string.Empty, Kata.OnesComplement(string.Empty));
        }

        [TestMethod]
        public void Input_1_Should_Be_0()
        {
            Assert.AreEqual("0", Kata.OnesComplement("1"));
        }

        [TestMethod]
        public void Input_11_Should_Be_00()
        {
            Assert.AreEqual("00", Kata.OnesComplement("11"));
        }

        [TestMethod]
        public void Input_0_Should_Be_1()
        {
            Assert.AreEqual("1", Kata.OnesComplement("0"));
        }

        [TestMethod]
        public void Input_00_Should_Be_11()
        {
            Assert.AreEqual("11", Kata.OnesComplement("00"));
        }
    }

    public class Kata
    {
        public static string OnesComplement(string n)
        {
            if (string.IsNullOrEmpty(n))
                return string.Empty;
            var nArray = n.ToCharArray();
            for (var i = 0; i < nArray.Length; i++)
            {
                nArray[i] = NotItNumber(nArray[i]);
            }
            return new string(nArray);
        }

        private static char NotItNumber(char nArray)
        {
            if (nArray.Equals('0'))
            {
                return '1';
            }
            return '0';
        }
    }
}
