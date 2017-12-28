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
    }

    public class Kata
    {
        public static string OnesComplement(string n)
        {
            if (string.IsNullOrEmpty(n))
                return string.Empty;
            for (var i = 0; i < n.ToCharArray().Length; i++)
            {
                n.ToCharArray()[i] = '0';
            }
            return new string(n.ToCharArray());
        }
    }
}
