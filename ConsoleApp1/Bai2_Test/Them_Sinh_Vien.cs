using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bai2_Test
{
    [TestFixture]
    public class Them_Sinh_Vien
    {
        public Sinhvienpoly _svpoly;

        [SetUp]
        public void Setup()
        {
            _svpoly = new Sinhvienpoly();
        }

        [Test]
        // YC: Ký tự độ dài không được vượt quá 10 ký tự, tối thiểu 1 ký tự
        // Kỹ thuật biên (10 testcase)
        [TestCase("Nghia", "MaLop1", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("NghiaNghia", "MaLop1", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("N", "MaLop1", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "MaLopMa", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "M", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "Ma", "TenLop1", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "MaLop1", "TenLopMot", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "MaLop1", "Te", "Ma2", ExpectedResult = true)]
        [TestCase("Nghia", "MaLop1", "Te", "MaSinhVien", ExpectedResult = true)]
        [TestCase("Nghia", "MaLop1", "T", "MaSinhVien", ExpectedResult = true)]


        // Độ dài vượt quá 10 ký tự:
        [TestCase("NghiaNghiaaaac", "MaLop1", "TenLop1", "Ma2", ExpectedResult = typeof(Exception))]
        [TestCase("Nghia", "MaLopMaLopMaLop", "TenLopgg", "Ma2", ExpectedResult = typeof(Exception))]

        // Trùng mã sinh viên:
        [TestCase("Nghia", "MALop1", "TenLop1", "Ma1", ExpectedResult = typeof(Exception))]
        [TestCase("Nghia", "MALop1", "TenLop1", "Ma3", ExpectedResult = typeof(Exception))]

        // Để trống 1 trường hoặc nhập phím cách:
        [TestCase("Nghia", "MALop1", "     ", "Ma1", ExpectedResult = typeof(Exception))]
        [TestCase("Nghia", "    ", "TenLop1", "Ma3", ExpectedResult = typeof(Exception))]

        // Tên Lớp chứa ký tự đặc biêt:
        [TestCase("Nghia", "MA", "$@$", "Ma8", ExpectedResult = typeof(Exception))]

        public bool ThemSv(string hoten, string malop, string tenlop, string masv)
        {
            Sinhvien Nghia1 = new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma1");
            Sinhvien Nghia2 = new Sinhvien("id", "Nghia", "MaLop1", "TenLop1", "Ma3");
            _svpoly.AddSV(Nghia1);
            _svpoly.AddSV(Nghia2);
            Sinhvien svmoi = new Sinhvien("id", hoten, malop, tenlop, masv);

            //Assert.That(_svpoly.svien.Contains(_sv), Is.True);
            return _svpoly.AddSV(svmoi);

        }

    }
}
