using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bai2_Test
{
    [TestFixture]
    public class TimKiemTheoMSV
    {
        public Sinhvienpoly _svpoly;

        [SetUp]
        public void Setup()
        {
            _svpoly = new Sinhvienpoly();
        }

        [Test]
        // YC: Ký tự độ dài không được vượt quá 10 ký tự, tối thiểu 1 ký tự
        // Kỹ thuật phân vùng tương đương (10 testcase)
        [TestCase("Ma2", ExpectedResult = true)]
        [TestCase("Ma3", ExpectedResult = true)]
        [TestCase("Ma4", ExpectedResult = true)]
        [TestCase("Ma5", ExpectedResult = true)]
        [TestCase("Ma6", ExpectedResult = true)]
        [TestCase("Ma7", ExpectedResult = true)]
        [TestCase("Ma8", ExpectedResult = true)]
        [TestCase("Ma9", ExpectedResult = true)]
        [TestCase("MaPH", ExpectedResult = true)]


        // Trường hợp ko tìm thấy 
        [TestCase("MaPeeH", ExpectedResult = false)]
        [TestCase("MaPee23H", ExpectedResult = false)]
        [TestCase("MaPee4H", ExpectedResult = false)]
        [TestCase("MeH", ExpectedResult = false)]
        public bool TimTheoMSV(string masv)
        {
            if (masv.Length > 10)
            {
                throw new Exception("Quá độ dài cho phép");
            }

            _svpoly.svien = new List<Sinhvien>()
            {
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "MaPH"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma2"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma3"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma4"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma5"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma6"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma7"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma8"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma9"),
                new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma10"),
            };


            return _svpoly.svien.Any(x => x.masv == masv);
        }
    }
}
