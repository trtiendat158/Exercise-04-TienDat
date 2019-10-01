using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassExercise4a;

namespace ClassEx04_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);

        }
        [TestMethod]
        public void TestEven()
        {
            bool result2 = Program.IsEven(2);
            Assert.AreEqual(true, result2);

            bool result5 = Program.IsEven(5);
            Assert.AreEqual(false, result5);
        }
            
        [TestMethod]
        public void TestPrime()
        {
            bool result3 = Program.IsPrime(13);
            Assert.AreEqual(true, result3);
            bool result4 = Program.IsPrime(4);
            Assert.AreEqual(false, result4);
        }

        [TestMethod]
        public void Square()
        {
            int result2 = Program.Square(5);
            Assert.AreEqual(25, result2);

            int result8 = Program.Square(8);
            Assert.AreEqual(64, result8);
        }

        [TestMethod]
        public void Cube()
        {
            int result2 = Program.Cube(2);
            Assert.AreEqual(8, result2);

            int result8 = Program.Cube(3);
            Assert.AreEqual(27, result8);
        }

        [TestMethod]
        public void Pow()
        {
            int result2 = Program.Pow(5, 2);
            Assert.AreEqual(25, result2);

            int resultAm3 = Program.Pow(-3, 2);
            Assert.AreEqual(9, resultAm3);

            int resultAm4 = Program.Pow(-4, 5);
            Assert.AreEqual(-1024, resultAm4);

            int result8 = Program.Pow(8, -2);
            Assert.AreEqual(1 / 64, result8);

            int result0 = Program.Pow(10, 0);
            Assert.AreEqual(1, result0);
        }

        [TestMethod]
        public void Abs()
        {
            int result2 = Program.Abs(2);
            Assert.AreEqual(2, result2);

            int resultAm2 = Program.Abs(-2);
            Assert.AreEqual(2, resultAm2);

            int result0 = Program.Abs(0);
            Assert.AreEqual(0, result0);
        }

        [TestMethod]
        public void Ceil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result2);

        }

         [TestMethod]
        public void Floor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor(-2.3f);
            Assert.AreEqual(-3, result2);
        }

         [TestMethod]
         public void Factorial()
         {
             long result2 = Program.Factorial(2);
             Assert.AreEqual(2, result2);

             long result3 = Program.Factorial(3);
             Assert.AreEqual(6, result3);

             long result0 = Program.Factorial(0);
             Assert.AreEqual(1, result0);
         }
    }
}
