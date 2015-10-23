using System;
using Mathmagician
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
        }
    }
}
