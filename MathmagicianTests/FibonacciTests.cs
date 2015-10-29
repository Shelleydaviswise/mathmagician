using System;
using Mathmagician;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateClassInstance()
        //Haven't created the class yet. 
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            //Will have red lines during test writing. It's OK.
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int expected = 1;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);

        }
   
        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 1;
            int expected = 1;
            int actual = fib.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]
        public void FibonacciShouldPrintAVariableSequenceofNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            //Must create instance of the class before testing the class.
            int input = 8;
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21};
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void FibonacciPrintSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
