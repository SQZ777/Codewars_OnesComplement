using System;
using System.Collections;
using System.Linq;
using System.Text;
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
        public void Input_11_Should_Be_11()
        {
            Assert.AreEqual("00", Kata.OnesComplement("11"));
        }

        [TestMethod]
        public void Input_0_Should_Be_1()
        {
            Assert.AreEqual("1", Kata.OnesComplement("0"));
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
                nArray[i] = '0';
            }
            return new string(nArray);
        }
    }
}
