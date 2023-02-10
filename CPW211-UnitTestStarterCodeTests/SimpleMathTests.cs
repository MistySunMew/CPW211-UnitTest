using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double result = SimpleMath.Add(num1, num2);
            Assert.AreEqual(num1 + num2, result);
        }

        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = SimpleMath.Multiply(num1, num2);
            Assert.AreEqual(num1 * num2, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SimpleMath.Divide(1, 0));
        }

        [DataRow(5, 10)]
        [DataRow(10, 100)]
        [DataRow(-1, -10)]
        [TestMethod]
        public void Divide_TwoNumbers_ReturnsProduct(double num2, double num1) 
        {
            double result = SimpleMath.Divide(num1,num2);
            Assert.AreEqual(num1 / num2, result);
        }

        // TODO: Test subtract method with two valid numbers
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsProduct(double num1, double num2) 
        {
            double result = SimpleMath.Subtract(num1, num2);
            Assert.AreEqual(num1- num2, result);
        }
    }
}