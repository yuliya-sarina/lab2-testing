using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1.Tests
{
    [TestClass()]
    public class DrobTests
    {


        [TestMethod()]
        public void GetXTest1()
        {
            //arrange
            int x = 3;
            int expected = 3;
            //act
            Drob c = new Drob();
            c.Init(x, 2);
            int actual = c.GetX();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetXTest2()
        {
            //arrange
            int x = -2;
            int expected = -2;
            //act
            Drob c = new Drob();
            c.Init(x, 3);
            int actual = c.GetX();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetXTest3()
        {
            //arrange
            int x = 2;
            int expected = 2;
            //act
            Drob c = new Drob();
            c.Init(x, 3);
            int actual = c.GetX();
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetYTest1()
        {
            //arrange
            int y = -2;
            int expected = -2;
            //act
            Drob c = new Drob();
            c.Init(2, y);
            int actual = c.GetY();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetYTest2()
        {
            //arrange
            int y = 2;
            int expected = 2;
            //act
            Drob c = new Drob();
            c.Init(3, y);
            int actual = c.GetY();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetYTest3()
        {
            //arrange
            int y = 3;
            int expected = 3;
            //act
            Drob c = new Drob();
            c.Init(2, y);
            int actual = c.GetY();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VidelDrobTest1()
        {
            //arrange
            int x = 3;
            int y = 4;
            double expected = 0.75;
            //act
            Drob c = new Drob();
            c.Init(x, y);
            double actual = c.VidelDrob();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VidelDrobTest2()
        {
            //arrange
            int x = 5;
            int y = 4;
            double expected = 1.25;
            //act
            Drob c = new Drob();
            c.Init(x, y);
            double actual = c.VidelDrob();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VidelDrobTest3()
        {
            //arrange
            int x = -5;
            int y = -4;
            double expected = 1.25;
            //act
            Drob c = new Drob();
            c.Init(x, y);
            double actual = c.VidelDrob();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VidelDrobTest4()
        {
            //arrange
            int x = 5;
            int y = -4;
            double expected = -1.25;
            //act
            Drob c = new Drob();
            c.Init(x, y);
            double actual = c.VidelDrob();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VidelDrobTest5()
        {
            //arrange
            int x = -5;
            int y = 4;
            double expected = -1.25;
            //act
            Drob c = new Drob();
            c.Init(x, y);
            double actual = c.VidelDrob();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}