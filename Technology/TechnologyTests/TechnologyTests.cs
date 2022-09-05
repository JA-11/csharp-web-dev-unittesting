using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        Computer testComputer;
        Laptop testLaptop;
        SmartPhone testSmartPhone;

        [TestInitialize]
        public void CreateTechnologyObjects()
        {
            testComputer = new Computer(2, 3, true);
            testLaptop = new Laptop(2, 3, true, 7.5);
            testSmartPhone = new SmartPhone(1.5, 2, false, 100);
        }

        //Computer Class Test #1
        [TestMethod]
        public void TestIncreasingRam()
        {
            Assert.AreEqual(2, testComputer.Ram, .001);
            testComputer.IncreaseRam(3);
            Assert.AreEqual(5, testComputer.Ram, .001);
        }

        //Computer Class Test #2
        [TestMethod]
        public void TestIncreasingStorage()
        {
            Assert.AreEqual(3, testComputer.Storage, .001);
            testComputer.IncreaseStorage(10);
            Assert.AreEqual(13, testComputer.Storage, .001);
        }

        //Computer Class Test #3
        [TestMethod]
        public void TestKeyBoard()
        {
            Assert.IsTrue(testComputer.hasKeyboard);
        }

        //Laptop Class Test #1
        [TestMethod]
        public void TestIsClunky()
        {
            Assert.AreEqual(true, testLaptop.IsClunky());
        }

        //Laptop Class Test #2
        [TestMethod]
        public void TestWeight()
        {
            Assert.AreEqual(7.5, testLaptop.Weight, .001);
        }

        //Laptop Class Test #3
        [TestMethod]
        public void TestLaptopKeyBoard()
        {
            Assert.IsTrue(testLaptop.hasKeyboard);
        }

        //SmartPhone Class Test #1
        [TestMethod]
        public void TestNumberOfPictures()
        {
            Assert.AreEqual(100, testSmartPhone.NumberOfPictures, .001);
        }

        //SmartPhone Class Test 2
        [TestMethod]
        public void TestTakePicture()
        {
            testSmartPhone.TakePicture();
            Assert.AreEqual(101, testSmartPhone.NumberOfPictures);
        }

        //SmartPhone Class Test #3
        [TestMethod]
        public void TestSmartPhoneKeyBoard()
        {
            Assert.IsFalse(testSmartPhone.hasKeyboard);
        }

        //AbstractEntity Test
        [TestMethod]
        public void TestId()
        {
            Assert.AreEqual(1, testComputer.Id);
            Assert.AreEqual(2, testLaptop.Id);
            Assert.AreEqual(3, testSmartPhone.Id);
        }
    }
}