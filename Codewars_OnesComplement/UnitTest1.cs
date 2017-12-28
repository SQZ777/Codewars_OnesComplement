using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_OnesComplement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_StringEmpty()
        {
           Assert.AreEqual(string.Empty,Kata.OnesComplement(string.Empty));
        }

        [TestMethod]
        public void Input_1_Should_Be_0()
        {
            Assert.AreEqual(0,Kata.OnesComplement("1"));
        }
    }

    public class Kata
    {
        public static string OnesComplement(string empty)
        {
            return string.Empty;
        }
    }
}
