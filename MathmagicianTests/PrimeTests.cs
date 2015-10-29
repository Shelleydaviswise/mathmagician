using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeTests 
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        //Haven't created the class yet. 
        {
            PrimeNumbers prime = new PrimeNumbers();
            //Will have red lines during test writing. It's OK.
            Assert.IsNotNull(prime);
        }


        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int expected = 2;
            int actual = prime.GetFirst();
            Assert.AreEqual(expected, actual);

        }
   

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int expected = 3;
            int input = 2;
            int actual = prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintAVariableSequenceofNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
           
            //Must create instance of the class before testing the class.
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] actual = prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }
      
        [TestMethod]
        public void PrimePrintSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int length = 7;
            string expected = "2 3 5 7 11 13 17";
            string actual = prime.ToString(prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeFindIndexOfElement()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            int expected = 21;
            int actual = prime.FindIndex(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeFindIndexofElementFails()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 103;
            prime.FindIndex(input);
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeGetNextNonPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 105;
            prime.GetNext(input);
        }

        [TestMethod]
        public void PrimeIsPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 20;
            bool expected = false;
            bool actual = prime.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIsNotPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            bool expected = true;
            bool actual = prime.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

