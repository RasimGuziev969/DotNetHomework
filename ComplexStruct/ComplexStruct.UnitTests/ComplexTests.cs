using NUnit.Framework;
using System;

namespace ComplexStruct.UnitTests
{
    [TestFixture]
    public class ComplexTests
    {
        [Test]
        public void ConstructorTest()
        {
            var angle = new Complex(-42, 18);

            Assert.That(angle.Re, Is.EqualTo(-42));
            Assert.That(angle.Im, Is.EqualTo(18));
        }

      
        [TestCase(15, 42, 1989)]
        [TestCase(0, 0, 0)]
        [TestCase(-15, 42, 1989)]
        public void ValueAbsTest( double re, double im, double result)
        {
            var complex = new Complex(re, im);
            var complexAbs = complex.Abs();
            Assert.That(complexAbs, Is.EqualTo(Math.Sqrt(result)));
        }

        [TestCase(15, 42, "15+42i")]
        [TestCase(0, 0, "0")]
        [TestCase(-15, 42, "-15+42i")]
        [TestCase(1, 1, "1+i")]
        public void ToStringTest(double re, double im, string result)
        {
            var complex = new Complex(re,im);

            Assert.That(complex.ToString(), Is.EqualTo(result));
        }

        

        [TestCase(30, 40, 50, 20, 80, 60)]
        [TestCase(30, 40, 50, -20, 80, 20)]
        [TestCase(-30, 40, 50, 20, 20, 60)]
        [TestCase(30, 40, 50, 0,80,40)]
        public void PlusTest(
            double degrees1, double minutes1,
            double degrees2, double minutes2,
            double resultDegrees, double resultMinutes)
        {
            var angle1 = new Complex(degrees1, minutes1);
            var angle2 = new Complex(degrees2, minutes2);
            var calcResult = angle1 + angle2;
            var result = new Complex(resultDegrees, resultMinutes);

            Assert.That(calcResult, Is.EqualTo(result));
        }

        [TestCase(2, 31, 41, 51, 43, 72)]
        [TestCase(0.5, 31, 41, 51, 41.5, 72)]
        public void MinusTest(
            double re1 , double im1,
            double re2, double im2,
            double resRe, double resIm)
        {
            var complex1 = new Complex(re1, im1);
            var complex2 = new Complex(re2, im2);
            var calcResut = complex1 - complex2;
            var complexResult = new Complex(resRe, resIm);
            Assert.That(calcResut, Is.EqualTo(complexResult));
        }
    }
}