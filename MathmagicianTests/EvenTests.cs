using System;
using Mathmagician;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
            Assert.IsNotNull(even);
        }

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            EvenNumbers even = new EvenNumbers();
            int expected = 2;
            int actual = even.GetFirst();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShouldPrintSequenceofNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            //Must create instance of the class before testing the class.
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = even.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            EvenNumbers even = new EvenNumbers();
            int input = 2;
            int expected = 4;
            int actual = even.GetNext(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ShouldPrintAVariableSequenceofNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            //Must create instance of the class before testing the class.
            int input = 8;
            int[] expected = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] actual = even.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            int length = 7;
            string expected = "2 4 6 8 10 14 16";
            string actual = even.ToString(even.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

    }
}
