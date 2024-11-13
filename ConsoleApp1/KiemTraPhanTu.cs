using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class KiemTraPhanTu
    {

        [Test]
        [TestCase(new int[] { 7, 8, 9 }, ExpectedResult = 7)]
        [TestCase(new int[] { -7, 8, 9 }, ExpectedResult = -7)]
        [TestCase(new int[] { -21, 8, -99 }, ExpectedResult = -99)]

        [TestCase(new int[] { }, ExpectedResult = null)]
        public int? phantubenhat(int[] phantu)
        {
            if (phantu == null || phantu.Length == 0)
            {
                throw new ArgumentException("Mảng không được phép rỗng.");
                return null;
            }

            int min = int.MaxValue;
            for (int i = 0; i < phantu.Length; i++)
            {
                if (phantu[i] < min)
                {
                    min = phantu[i];
                }
            }

            return min;
        }


    }
}
