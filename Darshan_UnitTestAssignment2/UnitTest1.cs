using Microsoft.VisualStudio.TestTools.UnitTesting;
using DarshanBhagavath_Assignment2;
using System;
//using NUnit.Framework;

namespace Darshan_UnitTestAssignment2
{
    //Test case with correct result
    [TestClass]
    public class RectangleTest
    {
        //Test case with correct result for positive value
        [TestMethod]
        public void GetPerimeter()
        {
            Rectangle r = new Rectangle();
            r.GetLength();
            r.GetWidth();
            r.SetLength(1);
            r.SetWidth(1);
            int result = r.GetPerimeter();
            Assert.AreEqual(4, result);
        }

        //Test case with correct result for positive value
        [TestMethod]
        public void GetArea()
        {
            Rectangle r = new Rectangle();
            r.GetLength();
            r.GetWidth();
            r.SetLength(1);
            r.SetWidth(1);
            int result = r.GetArea();
            //Assert.That(result, Is.EqualTo(1));
            Assert.AreEqual(1, result);
        }        

        //Test case with correct result
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 2, 8)]
        public void GetPeri(int length, int width, int expected)
        {
            Rectangle r = new Rectangle(length, width);
            int result = r.GetPerimeter();
            Assert.AreEqual(expected, result);
        }

        //Test case with correct result
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 2, 4)]
        public void GetAr(int length, int width, int expected)
        {
            Rectangle r = new Rectangle(length, width);
            int result = r.GetArea();
            Assert.AreEqual(expected, result);
        }

        //Test case with negative value
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]        
        public void GetPerimeterForNegative()
        {
            int length = -2;
            int width = -4;

            Rectangle r = new Rectangle(length, width);
            r.GetLength();
            r.GetWidth();
            r.SetLength(length);
            r.SetWidth(width);
            Action result = () => r.GetPerimeter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(result);
        }

        //Test case with negative value for area
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetAreaForNegative()
        {
                int length = -6;
                int width = -4;

                Rectangle r = new Rectangle(length, width);
                r.GetLength();
                r.GetWidth();
                r.SetLength(length);
                r.SetWidth(width);
                Action result = () => r.GetArea();
                Assert.ThrowsException<ArgumentOutOfRangeException>(result); 
         }

        //Test case with incorrect expected result
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 2, 10)]
        public void GetPerimeterValue(int length, int width, int expected)
        {
            Rectangle r = new Rectangle(length, width);
            int result = r.GetPerimeter();
            Assert.AreNotEqual(expected, result);
        }

        //Test case with incorrect expected result
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 2, 12)]
        public void GetAreaValue(int length, int width, int expected)
        {
            Rectangle r = new Rectangle(length, width);
            int result = r.GetArea();
            Assert.AreNotEqual(expected, result);
        }
    }
}
