using NUnit.Framework;
using System;

namespace ConsoleApp1.Bai1_Test
{
    [TestFixture]
    public class Hieu
    {
        public Bai1_Services _services;

        [SetUp]
        public void Setup()
        {
            _services = new Bai1_Services();
        }

        [Test]
        // a: 0 - 10
        // b: 0 - 10
        // Kỹ thuật biên (12 testcase)
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(10, 10, ExpectedResult = 0)]
        [TestCase(9, 9, ExpectedResult = 0)]
        [TestCase(1, 10, ExpectedResult = -9)]
        [TestCase(10, 1, ExpectedResult = 9)]
        [TestCase(9, 10, ExpectedResult = -1)]
        [TestCase(8, 10, ExpectedResult = -2)]
        [TestCase(8, 9, ExpectedResult = -1)]
        [TestCase(8, 1, ExpectedResult = 7)]
        [TestCase(-1, 1, ExpectedResult = typeof(Exception))]
        [TestCase(8, 11, ExpectedResult = typeof(Exception))]

        // Kỹ thuật phân vùng tương đương (12 testcase)
        [TestCase(3, 3, ExpectedResult = 0)]
        [TestCase(4, 4, ExpectedResult = 0)]
        [TestCase(5, 5, ExpectedResult = 0)]
        [TestCase(6, 6, ExpectedResult = 0)]
        [TestCase(7, 7, ExpectedResult = 0)]
        [TestCase(3, 7, ExpectedResult = -4)]
        [TestCase(4, 6, ExpectedResult = -2)]
        [TestCase(5, 5, ExpectedResult = 0)]
        [TestCase(6, 4, ExpectedResult = 2)]
        [TestCase(7, 3, ExpectedResult = 4)]
        [TestCase(9, "3", ExpectedResult = typeof(Exception))]
        [TestCase(null, 2, ExpectedResult = typeof(Exception))]
        public int TinhHieu(object a, object b)
        {
            return _services.hieu(a, b);
        }

    }
}
