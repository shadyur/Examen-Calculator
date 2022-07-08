using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exam_v_1;

namespace CalculaturTesting
{
    [TestClass]
    public class CalculatorTesting
    {
        [TestMethod]
        public void Summa_12_34()
        {
            // Arrange предусловие
            {
                int a = 12;
                int b = 34;
                int expected = 46;
            // Act действие
                int actual = Calculator.Sum(a,b);
            // Assert постусловие
             Assert.AreEqual(expected, actual);
            }
        }
        public void Difference_54_32()
        {
            // Arrange предусловие
            {
                int a = 54;
                int b = 32;
                int expected = 22;
            // Act действие
                int actual = Calculator.Difference(a, b);
            // Assert постусловие
                Assert.AreEqual(expected, actual);
            }
        }
        public void Product_5_12()
        {
            // Arrange предусловие
            {
                int a = 5;
                int b = 12;
                int expected = 60;
                // Act действие
                int actual = Calculator.Product(a, b);
                // Assert постусловие
                Assert.AreEqual(expected, actual);
            }
        }
        public void Division_55_11()
        {
            // Arrange предусловие
            {
                int a = 55;
                int b = 11;
                int expected = 5;
                // Act действие
                int actual = Calculator.Product(a, b);
                // Assert постусловие
                Assert.AreEqual(expected, actual);
            }
        }
        public void Division_44_0()
        {
            // Arrange предусловие
            {
                int a = 44;
                int b = 0;
                int expected = 55;
                // Act действие
                int actual = Calculator.Product(a, b);
                // Assert постусловие
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
