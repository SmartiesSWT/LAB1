using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExerc1;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private LabExerc1.Calculator uut;

        [SetUp]

        public void Setup()
        {
            // Arrange
            uut = new LabExerc1.Calculator();
        }

        [TestCase(4,0,4)]
        [TestCase(3, 0, 3)]
        [TestCase(-3, -9, -12)]
        public void Add2Numbers_ReturnSumOfNumbersAdded(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }


        [TestCase(5.5, 2.5, 3)]
        [TestCase(-5.5, 2.5, -8)]
        [TestCase(-5.5, -2.5, -3)]
        public void Subtract2Numbers_ReturnSumOfNumbersSubtracted(double a, double b, double result)
        {
            // Assert
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(5, 2, 10)]
        [TestCase(-5, 2, -10)]
        [TestCase(-5, -2, 10)]
        public void Multiply2Numbers_ReturnSumOfNumbersMultiplied(double a, double b, double result)
        {
            // Assert
            uut.Clear();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(-2, 3, -8)]
        [TestCase(-2, -3, -0.125)]
        public void PowerOfNumber_addedPower_ReturnSumOfNumberWithAddedPower(double a, double b, double result)
        {
            // Assert
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(6, 3, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(-5, 1, -5)]
        public void Divide2Numbers_ReturnSumOfNumbersDivided(double a, double b, double result)
        {
            // Assert
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));

            // Test af Exception
            Assert.That(() => uut.Divide(5, 0), Throws.TypeOf<ZeroException>());
        }


        [TestCase(6, 3, 2)]
        public void Accumulator_ReturnLastestFunction(double a, double b, double result)
        {
            // Assert
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(6, 3, 2)]
        public void Clear_SetAccumulatorToZero(double a, double b, double result)
        {
            // Assert
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(5, 5)]
        [TestCase(3, 3)]
        [TestCase(1, 1)]
        public void OverloadAdd_AccumulatorAdd(double a, double result)
        {
            // Assert
            uut.Clear();
            Assert.That(uut.Add(a), Is.EqualTo(result));
        }

        [TestCase(5, -5)]
        [TestCase(3, -3)]
        [TestCase(1, -1)]
        public void OverloadSubtract_AccumulatorSubtract(double a, double result)
        {
            // Assert
            uut.Clear();
            Assert.That(uut.Subtract(a), Is.EqualTo(result));
        }

        [TestCase(5, 35)]
        [TestCase(3, 21)]
        [TestCase(1, 7)]
        public void OverloadMultiply_AccumulatorMultiply(double a, double result)
        {
            // Assert
            uut.Clear();
            uut.Add(5, 2); 
            Assert.That(uut.Multiply(a), Is.EqualTo(result));
        }

        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(-4, -0.0625)]
        public void OverloadPower_AccumulatorPower(double a, double result)
        {
            // Assert
            uut.Clear();
            uut.Add(-1,-1);
            Assert.That(uut.Power(a), Is.EqualTo(result));
        }

        [TestCase(2, 5)]
        [TestCase(5, 2)]
        [TestCase(10, 1)]
        public void OverloadDivide_AccumulatorDivide(double a, double result)
        {
            // Assert
            uut.Clear();
            uut.Add(5, 5);
            Assert.That(uut.Divide(a), Is.EqualTo(result));
        }
    }
}
