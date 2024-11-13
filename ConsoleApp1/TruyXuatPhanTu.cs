using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class TruyXuatPhanTu
    {
        [Test]
        // Trường hợp đúng
        [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 9, 4, 5 }, 2, ExpectedResult = 9)]
        [TestCase(new int[] { 1, 3, 4 }, 2, ExpectedResult = 4)]
        [TestCase(new int[] { 3, 4, 5, 6, 7, 8 }, 5, ExpectedResult = 8)]

        // Trường hợp dính exception
        [TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = null)]
        [TestCase(new int[] { -1, 0, 1 }, 6, ExpectedResult = null)]
        [TestCase(new int[] { -3, -2, -1 }, 9, ExpectedResult = null)]
        public int? TruyXuat(int[] dayso, int? index)
        {
            // Nếu mà giá trị truy xuất > chiều dài dãy số => trả về exxception
            if (dayso.Count() < index)
            {
                Assert.Throws<IndexOutOfRangeException>(() => { });
                return null;
            }

            // Trả về giá trị tại chỉ mục
            return dayso[(int)index];
        }




    }
}
