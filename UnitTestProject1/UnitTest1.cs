using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinceProgram;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfReturnsOnly50_ReturnsAllright()
        {
            int cena = 200; bool setFalse = false;
            Program.KolikVratit(cena, setFalse, setFalse, setFalse, setFalse, setFalse);
            Assert.AreEqual(4, Program.padesat);
        }
        [TestMethod]
        public void TestIfReturns_ReturnsAllright()
        {
            int cena = 239; bool setFalse = false;
            Program.KolikVratit(cena, setFalse, setFalse, setFalse, setFalse, setFalse);
            Assert.AreEqual(4, Program.padesat);
            Assert.AreEqual(1, Program.dvacet);
            Assert.AreEqual(1, Program.deset);
            Assert.AreEqual(1, Program.petc);
            Assert.AreEqual(2, Program.dvac);
        }
        [TestMethod]
        public void TestIfReturnsOnly50_ReturnsBadAllright()
        {
            int cena = 200; bool setFalse = false;
            Program.KolikVratit(cena, setFalse, setFalse, setFalse, setFalse, setFalse);
            Assert.AreNotEqual(3, Program.padesat);
        }
    }
}
