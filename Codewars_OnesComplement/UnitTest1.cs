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
    }

    public class Kata
    {
        public static string OnesComplement(string empty)
        {
            throw new NotImplementedException();
        }
    }
}
