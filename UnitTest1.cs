using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("龠瀹爚禴龡龢籥鑰龣龥鸙籲");
            Assert.AreEqual("龠", "瀹");
        }
    }
}
