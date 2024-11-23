using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1.Bai1_Test
{
    [TestFixture]
    public class TBC
    {
        public Bai1_Services _services;

        [Test]
        // (20 testcase thường)
        [TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = 2.5)]
        [TestCase(new int[] { 3, 5, 2, 1, 1 }, 5, ExpectedResult = 2.4)]
        [TestCase(new int[] { 4, 8, 6, 2 }, 2, ExpectedResult = 10)]
        [TestCase(new int[] { 10, 20, 30 }, 3, ExpectedResult = 20)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, ExpectedResult = 3)]
        [TestCase(new int[] { 7, 14, 21, 28 }, 4, ExpectedResult = 17.5)]
        [TestCase(new int[] { 3, 6, 9, 12, 15 }, 5, ExpectedResult = 9)]
        [TestCase(new int[] { 1, 3, 2 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 6, 12, 18, 24 }, 4, ExpectedResult = 15)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 5, 15 }, 3, ExpectedResult = 10)]
        [TestCase(new int[] { 100, 200, 300 }, 3, ExpectedResult = 200)]
        [TestCase(new int[] { 4, 6, 8, 10, 12 }, 5, ExpectedResult = 8)]
        [TestCase(new int[] { 2, 4, 6 }, 3, ExpectedResult = 4)]
        [TestCase(new int[] { 9, 18, 27, 36 }, 4, ExpectedResult = 22.5)]
        [TestCase(new int[] { 2, 2, 2, 2 }, 4, ExpectedResult = 2)]
        [TestCase(new int[] { 50, 60, 70, 80 }, 4, ExpectedResult = 65)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 4, ExpectedResult = 4)]
        [TestCase(new int[] { 12, 24, 36, 48 }, 4, ExpectedResult = 30)]
        [TestCase(new int[] { 8, 16, 24 }, 3, ExpectedResult = 16)]


        // Trường hợp dính exception (3 testcase)
        [TestCase(new int[] { }, null, ExpectedResult = typeof(ArgumentNullException))]
        [TestCase(new int[] { 10, 20, 30 }, 0, ExpectedResult = typeof(ArithmeticException))]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, ExpectedResult = typeof(ArithmeticException))]

        public double? trungbinhcong(int[] dayso, int? chia)
        {

            if (!chia.HasValue || dayso.Count() == 0)
            {
                throw new ArgumentNullException("Không được bỏ trống");
            }
            // Trong trường hợp dãy số bị trống => trả về exception
            if (chia == 0)
            {
                throw new ArithmeticException("Lỗi phép tinhs");
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
