using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson5_oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_oop.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void CalculateTest()
        {

            // check if Fibonacci class calculation is correct for Number = 10
            int expected_return = 55;

            int actual_return = 0;


            // Chapter 5:: exercise 
            // actual_return ==??? how to get it?




            Assert.AreEqual(expected_return, actual_return);
        }

        [TestMethod()]
        public void CalculateRecursionTest()
        {
            var n = 10;
            var expected = 55;

            Fibonacci fb = new Fibonacci();

            var actual = fb.CalculateRecursion(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateDppTest()
        {
            var n = 10;
            var expected = 55;

            Fibonacci fb = new Fibonacci();

            var actual = fb.CalculateDpp(n);

            Assert.AreEqual(expected, actual);
        }
    }
}