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
    }
}
