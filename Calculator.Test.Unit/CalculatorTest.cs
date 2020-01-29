﻿using System;
using System.Collections.Generic;
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

        
        [Test]
        public void Add2Numbers_ReturnSumOfNumbersAdded()
        {
            ///Arrange
            //var uut = new LabExerc1.Calculator();                           // Anvendes i Setup metoden

            //Act
            uut.Add(2.5, 5.5);
            uut.Add(-2.5, 5.5);
            uut.Add(-2.5, -5.5);
            uut.Add(-3.5, -5.5);
            uut.Add(-4.5, -5.5);

            // Assert
            Assert.That(uut.Add(2.5, 5.5), Is.EqualTo(8));
            Assert.That(uut.Add(-2.5, 5.5), Is.EqualTo(3));
            Assert.That(uut.Add(-2.5, -5.5), Is.EqualTo(-8));
            Assert.That(uut.Add(-3.5, -5.5), Is.EqualTo(-9));
            Assert.That(uut.Add(-4.5, -5.5), Is.EqualTo(-10));






        }

        [Test]
        public void Subtract2Numbers_ReturnSumOfNumbersSubtracted()
        {
            // Arrange
            //var uut = new LabExerc1.Calculator();                           // Anvendes i Setup metoden

            // Act
            uut.Subtract(5.5, 2.5);
            uut.Subtract(-5.5, 2.5);
            uut.Subtract(-5.5, -2.5);

            // Assert
            Assert.That(uut.Subtract(5.5, 2.5), Is.EqualTo(3));
            Assert.That(uut.Subtract(-5.5, 2.5), Is.EqualTo(-8));
            Assert.That(uut.Subtract(-5.5, -2.5), Is.EqualTo(-3));

        }

        [Test]
        public void Multiply2Numbers_ReturnSumOfNumbersMultiplied()
        {
            // Arrange
            //var uut = new LabExerc1.Calculator();                           // Anvendes i Setup metoden

            // Act
            uut.Multiply(5, 2);
            uut.Multiply(-5, 2);
            uut.Multiply(-5, -2);

            // Assert
            Assert.That(uut.Multiply(5, 2), Is.EqualTo(10));
            Assert.That(uut.Multiply(-5, 2), Is.EqualTo(-10));
            Assert.That(uut.Multiply(-5, -2), Is.EqualTo(10));

        }

        [Test]
        public void PowerOfNumber_addedPower_ReturnSumOfNumberWithAddedPower()
        {
            // Arrange
            //var uut = new LabExerc1.Calculator();                           // Anvendes i Setup metoden

            // Act
            uut.Power(2, 3);
            uut.Power(-2, 3);
            uut.Power(-2, -3);

            // Assert
            Assert.That(uut.Power(2, 3), Is.EqualTo(8));
            Assert.That(uut.Power(-2, 3), Is.EqualTo(-8));
            Assert.That(uut.Power(-2, -3), Is.EqualTo(-0.125));

        }


        [Test]
        public void Divide2Numbers_ReturnSumOfNumbersDivided()
        {
            // Arrange
            //var uut = new LabExerc1.Calculator();                           // Anvendes i Setup metoden

            // Act
            //uut.Divide(6, 3);
            //uut.Divide(9, 3);
            //uut.Divide(5, 0);

            // Assert
            Assert.That(uut.Divide(6, 3), Is.EqualTo(2));
            Assert.That(uut.Divide(9, 3), Is.EqualTo(3));
            Assert.That(() => uut.Divide(5, 0), Throws.TypeOf<ZeroException>());

        }


        [Test]
        public void Accumulator_ReturnLastestFunction()
        {
            // Assert
            Assert.That(uut.Divide(9, 3), Is.EqualTo(3));
            Assert.That(uut.Accumulator, Is.EqualTo(3));

        }

        [Test]
        public void Clear_SetAccumulatorToZero()
        {
            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}
