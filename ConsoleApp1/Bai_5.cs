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

        [Test]
        [TestCase("Nghia",ExpectedResult = true)]
        public bool XuatTen(string ten)
        {
            NguoiDung truyvan = new NguoiDung();

            return truyvan.listnguoidung.Any(a => a.ten == ten);
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
