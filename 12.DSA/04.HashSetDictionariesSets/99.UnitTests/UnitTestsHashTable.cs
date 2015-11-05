namespace _99.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using _04.HashTableImplementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsHashTable
    {
        private MyHashTable<string, string> myHashTable = new MyHashTable<string, string>();

        public object MessageBox { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {
            var random = new Random();

            for (int i = 0; i < 50; i++)
            {
                this.myHashTable.Add(HelperMethods.GetRandomString(), HelperMethods.GetRandomString());
                Thread.Sleep(1);
            }
        }

        [TestMethod]
        public void CountShouldWorkProperly()
        {
            this.myHashTable.Add("useless", "uselessValue");
            Assert.AreEqual(51, this.myHashTable.Count);
            this.myHashTable.Remove("useless");
            Assert.AreEqual(50, this.myHashTable.Count);
        }

        [TestMethod]
        public void MyHashTableShouldHaveAValidNumberOfEntries()
        {
            Assert.AreEqual(50, this.myHashTable.Count);
        }

        [TestMethod]
        public void AddShouldAddEntries()
        {
            this.myHashTable.Add("useless", "useless");
            Assert.AreEqual(51, this.myHashTable.Count);
        }

        [TestMethod]
        public void RemoveShouldRemoveEntries()
        {
            this.myHashTable.Add("useless", "uselessValue");
            Assert.AreEqual(51, this.myHashTable.Count);
            this.myHashTable.Remove("useless");
            Assert.AreEqual(50, this.myHashTable.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveShouldThrowIfTryingToRemoveNonExistingEntry()
        {
            this.myHashTable.Remove("useless");
        }

        [TestMethod]
        public void FindShouldReturnEntries()
        {
            this.myHashTable.Add("useless", "uselessValue");
            var found = this.myHashTable.Find("useless");
            Assert.AreEqual("uselessValue", found);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void FindShouldThrowIfKeyIsNotFound()
        {
            var found = this.myHashTable.Find("useless");
        }

        [TestMethod]
        public void ClearShouldRemoveAllEntries()
        {
            this.myHashTable.Clear();
            Assert.AreEqual(0, this.myHashTable.Count);
        }

        [TestMethod]
        public void ForEachShouldWork()
        {
            this.myHashTable.Clear();
            this.myHashTable.Add("item1", "value1");

            foreach (var item in this.myHashTable)
            {
                Assert.AreEqual("value1", item.Value);
            }
        }

        [TestMethod]
        public void KeysShouldReturnTheKeys()
        {
            this.myHashTable.Clear();
            this.myHashTable.Add("item1", "value1");

            var keys = this.myHashTable.Keys;

            foreach (var key in keys)
            {
                Assert.AreEqual("item1", key);
            }
        }
    }
}
