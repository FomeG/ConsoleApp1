using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class Phep_Chia
    {
        [Test]
        // a: -100 -> 100
        // b: -100 -> 100

        // kỹ thuật biên
        [TestCase(100, -100, ExpectedResult = -1)]
        [TestCase(-100, 100, ExpectedResult = -1)]
        [TestCase(99, 99, ExpectedResult = 1)]
        [TestCase(-99, -99, ExpectedResult = 1)]
        [TestCase(98, -98, ExpectedResult = -1)]
        [TestCase(101, 20, ExpectedResult = null)]
        [TestCase(-101, 20, ExpectedResult = null)]

        // kỹ thuật phân vùng tương đương
        [TestCase(12, 6, ExpectedResult = 2)]
        [TestCase(9, 6, ExpectedResult = 1.5)]
        [TestCase(12, 0, ExpectedResult = null)]

        public double? phep_chia(double a, double b)
        {
            if (b == 0)
            {
                Assert.Fail("Không thể chia được cho 0");
                return null;
            }

            if (a > 100 || a < -100 || b > 100 || b < -100)
            {
                Assert.Fail("Giá trị ngoài khoảng");
                return null;
            }

            return a / b;
        }



    }





    //public class math
    //{
    //    public double phepchia(double a, double b)
    //    {
    //        return a / b;
    //    }
    //}
}
