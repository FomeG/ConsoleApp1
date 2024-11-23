using ConsoleApp1.Bai1_Test;
using NUnit.Framework;
using System;
using System.Linq;

namespace ConsoleApp1.Bai1_Test
{
    [TestFixture]
    public class TruyXuatPhanTuTrongMang
    {
        public Bai1_Services _services;

        [SetUp]
        public void Setup()
        {
            _services = new Bai1_Services();
        }

        [Test]
        // Trường hợp đúng
        [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 9, 4, 5 }, 2, ExpectedResult = 9)]
        [TestCase(new int[] { 1, 3, 4 }, 2, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 3, 4 }, 2, ExpectedResult = 4)]
        [TestCase(new int[] { 3, 4, 5, 6, 7, 8 }, 5, ExpectedResult = 8)]

        // Trường hợp dính exception
        [TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = typeof(IndexOutOfRangeException))]
        [TestCase(new int[] { -1, 0, 1 }, 6, ExpectedResult = typeof(IndexOutOfRangeException))]
        [TestCase(new int[] { -3, -2, -1 }, 9, ExpectedResult = typeof(IndexOutOfRangeException))]
        [TestCase(new int[] { }, 1, ExpectedResult = typeof(ArgumentNullException))]
        public int? TruyXuat(int[] dayso, int? index)
        {
            //Check trooongs
            if (!index.HasValue || dayso.Count() == 0)
            {
                throw new ArgumentNullException("Không được bỏ trống giá trị tìm kiếm");
            }

            // Nếu mà giá trị truy xuất > chiều dài dãy số => trả về exxception
            if (dayso.Count() < index)
            {
                //Assert.Throws<IndexOutOfRangeException>(() => { });
                throw new IndexOutOfRangeException("Giá trị tìm kiếm không hợp lệ");
            }

            // Trả về giá trị tại chỉ mục
            return dayso[(int)index];
        }



    }
}
