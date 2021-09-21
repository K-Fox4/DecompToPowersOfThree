using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecompositionPowersThree.structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecompositionPowersThree.structure.Tests
{

    [TestClass()]
    public class DecomposerTests
    {

        [TestMethod()]
        public void GetTheDecompositionTest1()
        {
            string expectedDecompOfnegative1 = "- 1 = - 1";
            var result = Decomposer.GetTheDecomposition(-1);
            Assert.AreEqual(expectedDecompOfnegative1, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest2()
        {
            string expectedDecompOf4 = "4 = 3 + 1";
            var result = Decomposer.GetTheDecomposition(4);
            Assert.AreEqual(expectedDecompOf4, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest3()
        {
            string expectedDecompOfnegative11 = "- 11 = - 9 - 3 + 1";
            var result = Decomposer.GetTheDecomposition(-11);
            Assert.AreEqual(expectedDecompOfnegative11, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest4()
        {
            string expectedDecompOf16 = "16 = 27 - 9 - 3 + 1";
            var result = Decomposer.GetTheDecomposition(16);
            Assert.AreEqual(expectedDecompOf16, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest5()
        {
            string expectedDecompOfnegative23 = "- 23 = - 27 + 3 + 1";
            var result = Decomposer.GetTheDecomposition(-23);
            Assert.AreEqual(expectedDecompOfnegative23, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest6()
        {
            string expectedDecompOf27 = "27 = 27";
            var result = Decomposer.GetTheDecomposition(27);
            Assert.AreEqual(expectedDecompOf27, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest7()
        {
            string expectedDecompOfnegative30 = "- 30 = - 27 - 3";
            var result = Decomposer.GetTheDecomposition(-30);
            Assert.AreEqual(expectedDecompOfnegative30, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest8()
        {
            string expectedDecompOf36 = "36 = 27 + 9";
            var result = Decomposer.GetTheDecomposition(36);
            Assert.AreEqual(expectedDecompOf36, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest9()
        {
            string expectedDecompOfnegative42 = "- 42 = - 81 + 27 + 9 + 3";
            var result = Decomposer.GetTheDecomposition(-42);
            Assert.AreEqual(expectedDecompOfnegative42, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest10()
        {
            string expectedDecompOf47 = "47 = 81 - 27 - 9 + 3 - 1";
            var result = Decomposer.GetTheDecomposition(47);
            Assert.AreEqual(expectedDecompOf47, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest11()
        {
            string expectedDecompOfnegative55 = "- 55 = - 81 + 27 - 1";
            var result = Decomposer.GetTheDecomposition(-55);
            Assert.AreEqual(expectedDecompOfnegative55, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest12()
        {
            string expectedDecompOf52 = "52 = 81 - 27 - 3 + 1";
            var result = Decomposer.GetTheDecomposition(52);
            Assert.AreEqual(expectedDecompOf52, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest13()
        {
            string expectedDecompOfnegative63 = "- 63 = - 81 + 27 - 9";
            var result = Decomposer.GetTheDecomposition(-63);
            Assert.AreEqual(expectedDecompOfnegative63, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest14()
        {
            string expectedDecompOf68 = "68 = 81 - 9 - 3 - 1";
            var result = Decomposer.GetTheDecomposition(68);
            Assert.AreEqual(expectedDecompOf68, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest15()
        {
            string expectedDecompOfnegative72 = "- 72 = - 81 + 9";
            var result = Decomposer.GetTheDecomposition(-72);
            Assert.AreEqual(expectedDecompOfnegative72, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest16()
        {
            string expectedDecompOf74 = "74 = 81 - 9 + 3 - 1";
            var result = Decomposer.GetTheDecomposition(74);
            Assert.AreEqual(expectedDecompOf74, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest17()
        {
            string expectedDecompOfnegative84 = "- 84 = - 81 - 3";
            var result = Decomposer.GetTheDecomposition(-84);
            Assert.AreEqual(expectedDecompOfnegative84, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest18()
        {
            string expectedDecompOf87 = "87 = 81 + 9 - 3";
            var result = Decomposer.GetTheDecomposition(87);
            Assert.AreEqual(expectedDecompOf87, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest19()
        {
            string expectedDecompOfnegative99 = "- 99 = - 81 - 27 + 9";
            var result = Decomposer.GetTheDecomposition(-99);
            Assert.AreEqual(expectedDecompOfnegative99, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest20()
        {
            string expectedDecompOf91 = "91 = 81 + 9 + 1";
            var result = Decomposer.GetTheDecomposition(91);
            Assert.AreEqual(expectedDecompOf91, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest21()
        {
            string expectedDecompOfnegative108 = "- 108 = - 81 - 27";
            var result = Decomposer.GetTheDecomposition(-108);
            Assert.AreEqual(expectedDecompOfnegative108, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest22()
        {
            string expectedDecompOf100 = "100 = 81 + 27 - 9 + 1";
            var result = Decomposer.GetTheDecomposition(100);
            Assert.AreEqual(expectedDecompOf100, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest23()
        {
            string expectedDecompOfnegative121 = "- 121 = - 81 - 27 - 9 - 3 - 1";
            var result = Decomposer.GetTheDecomposition(-121);
            Assert.AreEqual(expectedDecompOfnegative121, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest24()
        {
            string expectedDecompOf117 = "117 = 81 + 27 + 9";
            var result = Decomposer.GetTheDecomposition(117);
            Assert.AreEqual(expectedDecompOf117, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest25()
        {
            string notExpectedDecompOf1 = "1 = -1";
            var result = Decomposer.GetTheDecomposition(1);
            Assert.AreNotEqual(notExpectedDecompOf1, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest26()
        {
            string notExpectedDecompOfnegative3 = "- 3 = 3";
            var result = Decomposer.GetTheDecomposition(-3);
            Assert.AreNotEqual(notExpectedDecompOfnegative3, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest27()
        {
            string notExpectedDecompOf9 = "9 = - 9";
            var result = Decomposer.GetTheDecomposition(9);
            Assert.AreNotEqual(notExpectedDecompOf9, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest28()
        {
            string notExpectedDecompOfnegative27 = "- 27 = 27";
            var result = Decomposer.GetTheDecomposition(-27);
            Assert.AreNotEqual(notExpectedDecompOfnegative27, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest29()
        {
            string notExpectedDecompOf81 = "81 = - 81";
            var result = Decomposer.GetTheDecomposition(81);
            Assert.AreNotEqual(notExpectedDecompOf81, result);
        }

        [TestMethod()]
        public void GetTheDecompositionTest30()
        {
            string notExpectedDecompOfnegative81 = "- 81 = 81";
            var result = Decomposer.GetTheDecomposition(-81);
            Assert.AreNotEqual(notExpectedDecompOfnegative81, result);
        }

    }
}