using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest_When0()
        {

            int index = 0;

            var x = new Fibonacci().GetFibonacci(index);

            Assert.AreEqual(x, 0);
        }
        [TestMethod]
        public void FibonacciTest_WhenIndexIs5()
        {
            
            int index = 5;

            var x = new Fibonacci().GetFibonacci(index);

            Assert.AreEqual(x, 5);
        }
        [TestMethod]
        public void FibonacciTest_WhenIndexIsNegative1()
        {
            int index = -1;

            var x = new Fibonacci().GetFibonacci(index);

            Assert.AreEqual(x, 1);
        }

    }
}
