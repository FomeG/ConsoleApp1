using NUnit.Framework;

using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab2
    {
        static void Main(string[] args)
        {

        }
    }


    [TestFixture]
    public class Bai_1
    {

        [Test]
        // a: 1 -> 10
        // b: 1 -> 10
        // Kỹ thuật phân vùng biên
        [TestCase(1, 10, ExpectedResult = 11)]
        [TestCase(10, 1, ExpectedResult = 11)]
        [TestCase(9, 9, ExpectedResult = 18)]
        [TestCase(8, 8, ExpectedResult = 16)]
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(3, 3, ExpectedResult = 6)]

        // Kỹ thuật phân vùng tương đương
        [TestCase(3, 4, ExpectedResult = 7)]
        [TestCase(6, 7, ExpectedResult = 13)]
        [TestCase(5, 3, ExpectedResult = 8)]


        [TestCase(1, 2.4, ExpectedResult = null)]
        public int? tong(object a, object b)
        {
            if (int.TryParse(a.ToString(), out int c) && int.TryParse(b.ToString(), out int d))
            {
                //Console.WriteLine("Đây là 1 số nguyên");
                return c + d;
            }
            Assert.Fail("Đây không phải là 1 số nguyên");
            //Console.WriteLine("Đây ko là 1 số nguyên");
            return null;
        }

        [Test]
        [TestCase(1, 2, ExpectedResult = 3)]
        public int sum(int a, int b)
        {
            return a + b;
        }


    }


}
