using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumber;

namespace ComplexNum.Tests
{
    [TestClass]
    public class ComplexTests
    {
        #region Addition Tests
        [TestMethod]
        public void AdditionTest_PositiveNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 2, Imag = 1 };
            Complex expected = new Complex { Real = 5, Imag = 5 };

            // Act
            Complex result = c1 + c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void AdditionTest_NegativeNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = -3, Imag = -4 };
            Complex c2 = new Complex { Real = -2, Imag = -1 };
            Complex expected = new Complex { Real = -5, Imag = -5 };

            // Act
            Complex result = c1 + c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void AdditionTest_MixedNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 5, Imag = -2 };
            Complex c2 = new Complex { Real = -3, Imag = 6 };
            Complex expected = new Complex { Real = 2, Imag = 4 };

            // Act
            Complex result = c1 + c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void AdditionTest_WithZero()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 0, Imag = 0 };
            Complex expected = new Complex { Real = 3, Imag = 4 };

            // Act
            Complex result = c1 + c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }
        #endregion

        #region Subtraction Tests
        [TestMethod]
        public void SubtractionTest_PositiveNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 5, Imag = 6 };
            Complex c2 = new Complex { Real = 2, Imag = 3 };
            Complex expected = new Complex { Real = 3, Imag = 3 };

            // Act
            Complex result = c1 - c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void SubtractionTest_NegativeNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = -5, Imag = -6 };
            Complex c2 = new Complex { Real = -2, Imag = -3 };
            Complex expected = new Complex { Real = -3, Imag = -3 };

            // Act
            Complex result = c1 - c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void SubtractionTest_MixedNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 7, Imag = -4 };
            Complex c2 = new Complex { Real = -2, Imag = 3 };
            Complex expected = new Complex { Real = 9, Imag = -7 };

            // Act
            Complex result = c1 - c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void SubtractionTest_WithZero()
        {
            // Arrange
            Complex c1 = new Complex { Real = 4, Imag = 5 };
            Complex c2 = new Complex { Real = 0, Imag = 0 };
            Complex expected = new Complex { Real = 4, Imag = 5 };

            // Act
            Complex result = c1 - c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }
        #endregion

        #region Multiplication Tests
        [TestMethod]
        public void MultiplicationTest_PositiveNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 2, Imag = 3 };
            Complex c2 = new Complex { Real = 4, Imag = 5 };
            // (2+3i)(4+5i) = 8+10i+12i+15i² = 8+22i-15 = -7+22i
            Complex expected = new Complex { Real = -7, Imag = 22 };

            // Act
            Complex result = c1 * c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void MultiplicationTest_NegativeNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = -2, Imag = -3 };
            Complex c2 = new Complex { Real = -4, Imag = -5 };
            // (-2-3i)(-4-5i) = 8+10i+12i+15i² = 8+22i-15 = -7+22i
            Complex expected = new Complex { Real = -7, Imag = 22 };

            // Act
            Complex result = c1 * c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void MultiplicationTest_MixedNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = -2 };
            Complex c2 = new Complex { Real = -1, Imag = 4 };
            // (3-2i)(-1+4i) = -3+12i+2i-8i² = -3+14i+8 = 5+14i
            Complex expected = new Complex { Real = 5, Imag = 14 };

            // Act
            Complex result = c1 * c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }

        [TestMethod]
        public void MultiplicationTest_WithZero()
        {
            // Arrange
            Complex c1 = new Complex { Real = 5, Imag = 3 };
            Complex c2 = new Complex { Real = 0, Imag = 0 };
            Complex expected = new Complex { Real = 0, Imag = 0 };

            // Act
            Complex result = c1 * c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real);
            Assert.AreEqual(expected.Imag, result.Imag);
        }
        #endregion

        #region Division Tests
        [TestMethod]
        public void DivisionTest_PositiveNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 10, Imag = 5 };
            Complex c2 = new Complex { Real = 2, Imag = 1 };
            // (10+5i)/(2+1i) = (10+5i)(2-1i)/(2²+1²) = (20-10i+10i-5i²)/5 = (20+5)/5 = 5+0i
            Complex expected = new Complex { Real = 5, Imag = 0 };

            // Act
            Complex result = c1 / c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real, 0.0001);
            Assert.AreEqual(expected.Imag, result.Imag, 0.0001);
        }

        [TestMethod]
        public void DivisionTest_NegativeNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = -8, Imag = -4 };
            Complex c2 = new Complex { Real = -2, Imag = -1 };
            Complex expected = new Complex { Real = 4, Imag = 0 };

            // Act
            Complex result = c1 / c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real, 0.0001);
            Assert.AreEqual(expected.Imag, result.Imag, 0.0001);
        }

        [TestMethod]
        public void DivisionTest_ResultWithImaginaryPart()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 1, Imag = 2 };
            // (3+4i)/(1+2i) = (3+4i)(1-2i)/(1+4) = (3-6i+4i-8i²)/5 = (3-2i+8)/5 = (11-2i)/5
            Complex expected = new Complex { Real = 2.2, Imag = -0.4 };

            // Act
            Complex result = c1 / c2;

            // Assert
            Assert.AreEqual(expected.Real, result.Real, 0.0001);
            Assert.AreEqual(expected.Imag, result.Imag, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest_DivideByZero()
        {
            // Arrange
            Complex c1 = new Complex { Real = 5, Imag = 3 };
            Complex c2 = new Complex { Real = 0, Imag = 0 };

            // Act
            Complex result = c1 / c2;

            // Assert - Exception should be thrown
        }
        #endregion

        #region Equality Tests
        [TestMethod]
        public void EqualityTest_IdenticalNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 3, Imag = 4 };

            // Act
            bool result = c1 == c2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EqualityTest_DifferentNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 2, Imag = 5 };

            // Act
            bool result = c1 == c2;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EqualityTest_BothZero()
        {
            // Arrange
            Complex c1 = new Complex { Real = 0, Imag = 0 };
            Complex c2 = new Complex { Real = 0, Imag = 0 };

            // Act
            bool result = c1 == c2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EqualityTest_NegativeNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = -5, Imag = -7 };
            Complex c2 = new Complex { Real = -5, Imag = -7 };

            // Act
            bool result = c1 == c2;

            // Assert
            Assert.IsTrue(result);
        }
        #endregion

        #region Inequality Tests
        [TestMethod]
        public void InequalityTest_DifferentNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 2, Imag = 5 };

            // Act
            bool result = c1 != c2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InequalityTest_IdenticalNumbers()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 4 };
            Complex c2 = new Complex { Real = 3, Imag = 4 };

            // Act
            bool result = c1 != c2;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InequalityTest_DifferentRealParts()
        {
            // Arrange
            Complex c1 = new Complex { Real = 5, Imag = 4 };
            Complex c2 = new Complex { Real = 3, Imag = 4 };

            // Act
            bool result = c1 != c2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InequalityTest_DifferentImaginaryParts()
        {
            // Arrange
            Complex c1 = new Complex { Real = 3, Imag = 5 };
            Complex c2 = new Complex { Real = 3, Imag = 4 };

            // Act
            bool result = c1 != c2;

            // Assert
            Assert.IsTrue(result);
        }
        #endregion

        #region Increment Tests
        [TestMethod]
        public void IncrementTest_PositiveNumber()
        {
            // Arrange
            Complex c = new Complex { Real = 3, Imag = 4 };

            // Act
            Complex result = ++c;

            // Assert
            Assert.AreEqual(4, result.Real);
            Assert.AreEqual(4, result.Imag);
        }

        [TestMethod]
        public void IncrementTest_NegativeNumber()
        {
            // Arrange
            Complex c = new Complex { Real = -2, Imag = -5 };

            // Act
            Complex result = ++c;

            // Assert
            Assert.AreEqual(-1, result.Real);
            Assert.AreEqual(-5, result.Imag);
        }

        [TestMethod]
        public void IncrementTest_Zero()
        {
            // Arrange
            Complex c = new Complex { Real = 0, Imag = 0 };

            // Act
            Complex result = ++c;

            // Assert
            Assert.AreEqual(1, result.Real);
            Assert.AreEqual(0, result.Imag);
        }

        [TestMethod]
        public void IncrementTest_OnlyImaginaryPart()
        {
            // Arrange
            Complex c = new Complex { Real = 0, Imag = 5 };

            // Act
            Complex result = ++c;

            // Assert
            Assert.AreEqual(1, result.Real);
            Assert.AreEqual(5, result.Imag);
        }
        #endregion

        #region Decrement Tests
        [TestMethod]
        public void DecrementTest_PositiveNumber()
        {
            // Arrange
            Complex c = new Complex { Real = 5, Imag = 3 };

            // Act
            Complex result = --c;

            // Assert
            Assert.AreEqual(4, result.Real);
            Assert.AreEqual(3, result.Imag);
        }

        [TestMethod]
        public void DecrementTest_NegativeNumber()
        {
            // Arrange
            Complex c = new Complex { Real = -3, Imag = -5 };

            // Act
            Complex result = --c;

            // Assert
            Assert.AreEqual(-4, result.Real);
            Assert.AreEqual(-5, result.Imag);
        }

        [TestMethod]
        public void DecrementTest_Zero()
        {
            // Arrange
            Complex c = new Complex { Real = 0, Imag = 0 };

            // Act
            Complex result = --c;

            // Assert
            Assert.AreEqual(-1, result.Real);
            Assert.AreEqual(0, result.Imag);
        }

        [TestMethod]
        public void DecrementTest_OnlyImaginaryPart()
        {
            // Arrange
            Complex c = new Complex { Real = 0, Imag = 7 };

            // Act
            Complex result = --c;

            // Assert
            Assert.AreEqual(-1, result.Real);
            Assert.AreEqual(7, result.Imag);
        }
        #endregion
    }
}