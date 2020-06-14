using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            var testResult = testInstance.GroceryList.Length;
            Assert.AreEqual(4, testResult, "I expect the array length to be 4");
            Assert.AreEqual("Milk", testInstance.GroceryList[1]);
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("Bread"));
        }

        [TestMethod]
        public void TestContainsAnimal()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.containsAnimal("cat"));
            Assert.IsFalse(testInstance.containsAnimal("crocodil"));
        }
    }
}
