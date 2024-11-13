using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class Bai_5
    {
        public NguoiDung nd;

        [SetUp]
        public void khoitao()
        {
            nd = new NguoiDung();
        }

        [Test]
        [TestCase("Nghia", ExpectedResult = true)]
        [TestCase("An", ExpectedResult = false)]
        public bool XuatTen(string ten)
        {
            // Tìm thấy người dùng thì trả về true / ngược lại thì false
            return nd.listnguoidung.Any(a => a.ten == ten);
        }
    }


    // Khởi tạo class người dùng chứa danh sách người dùng
    public class NguoiDung
    {
        public string ten { get; set; } = string.Empty;
        public List<NguoiDung> listnguoidung = new List<NguoiDung>()
        {
               new NguoiDung { ten = "Nghia" },
               new NguoiDung { ten = "Duong" },
               new NguoiDung { ten = "Cuong" },
               new NguoiDung { ten = "Lam" },
               new NguoiDung { ten = "Son" }
        };

    }
}
