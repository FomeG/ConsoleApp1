using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class TBC
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = 2.5)]
        [TestCase(new int[] { 3, 5, 2, 1, 1 }, 5, ExpectedResult = 2.4)]
        [TestCase(new int[] { }, null, ExpectedResult = null)]
        public double? trungbinhcong(int[] dayso, int? chia)
        {
            // Trong trường hợp dãy số bị trống => trả về exception
            if (dayso.Count() == 0)
            {
                Assert.Throws<ArithmeticException>(() => { });
                return null;
            }

            // Truowngf hợp dãy số không trống => tính tổng
            int tong = 0;
            foreach (int so in dayso)
            {
                tong += so;
            }

            return (double)tong / (double)chia;

        }

    }
}
