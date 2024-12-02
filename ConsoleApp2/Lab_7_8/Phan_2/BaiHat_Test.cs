using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Lab_7_8.Phan_2
{
    [TestFixture]
    public class BaiHat_Test
    {
        private BaiHatServices services;


        [SetUp]
        public void setup()
        {
            services = new BaiHatServices();
        }


        [Test]
        // Phân vùng tương đương
        // Trường hợp thêm bình thường
        [TestCase("ID3", "Ten2", "TenCasi", 30, "NhacSi1", ExpectedResult = true)]
        [TestCase("ID4", "Ten2", "TenCasi2", 31, "NhacSi12", ExpectedResult = true)]
        [TestCase("ID5", "Ten2", "TenCasi1", 32, "NhacSi3", ExpectedResult = true)]
        [TestCase("ID6", "Ten2", "TenCasi3", 33, "NhacSi4", ExpectedResult = true)]
        [TestCase("ID7", "Ten2", "TenCasi4", 34, "NhacS51", ExpectedResult = true)]
        [TestCase("ID8", "Ten2", "TenCasi5", 35, "NhacSi1", ExpectedResult = true)]
        [TestCase("ID9", "Ten2", "TenCasi6", 36, "NhacSi1", ExpectedResult = true)]
        [TestCase("ID10", "Ten2", "TenCasi7", 37, "NhacSi1", ExpectedResult = true)]

        // Trường hợp Exception (độ dài không hợp lệ, hoặc bỏ trống, trùng ID)
        [TestCase("ID7", "Ten2", "TenCasi", -9, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("ID7", "Ten2", "TenCasi", -52, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("ID1", "", "", 90, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("", "", "", 232, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("", "22323", "", 374, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("", "4464544645", "qwdwqd", 516, "NhacSi1", ExpectedResult = typeof(Exception))]
        [TestCase("", "TenbaiHat", "", 658, "", ExpectedResult = typeof(Exception))]

        public bool ThemBH(string id, string ten, string tenCasi, int doDai, string tenNhacSi)
        {
            return services.Them(id, ten, tenCasi, doDai, tenNhacSi);
        }



        [Test]
        // Phân vùng tương đương
        // Trường hợp đúng
        [TestCase("id1", ExpectedResult = true)]
        [TestCase("id2", ExpectedResult = true)]
        [TestCase("id3", ExpectedResult = true)]
        [TestCase("id4", ExpectedResult = true)]
        [TestCase("id5", ExpectedResult = true)]

        // Trường hợp ngoại lệ (không tìm thấy ID, hoặc id để trống)
        [TestCase("", ExpectedResult = typeof(Exception))]
        [TestCase("id6", ExpectedResult = typeof(NullReferenceException))]
        [TestCase("id7", ExpectedResult = typeof(NullReferenceException))]
        [TestCase("id8", ExpectedResult = typeof(NullReferenceException))]
        [TestCase("id9", ExpectedResult = typeof(NullReferenceException))]
        [TestCase("id10", ExpectedResult = typeof(NullReferenceException))]
        public bool XoaBH(string id)
        {
            return services.Xoa(id);
        }


    }
}
