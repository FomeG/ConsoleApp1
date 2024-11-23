using ConsoleApp3.Test_CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        #region nghia
        NUNIT:
namespace Test_CRUD
    {
        public class NhanVienManager
        {
            public List<NhanVien> nhanViens = new List<NhanVien>();
            public int ID { get; set; }
            public string Name { get; set; }
            public NhanVien(int _ID, string _Name)
            {
                ID = _ID;
                Name = _Name;
            }
        }
    }

    TEST Nunit

using Test_CRUD;

namespace TestLog_CRUD
    {
        public class Tests
        {
            public NhanVienManager nhanVienManager;
            public NhanVien _nv;
            [SetUp]
            public void Setup()
            {
                nhanVienManager = new NhanVienManager();
            }

            [Test]
            public void Test_Add_Nhan_Vien()
            {
                //Assert.Pass();

                _nv = new NhanVien(0, "A");

                nhanVienManager.AddNhanVien(_nv);

                Assert.Contains(_nv, nhanVienManager.nhanViens);
            }
            [Test]
            public void Test_Update_Nhan_Vien()
            {
                //Assert.Pass();

                _nv = new NhanVien(0, "A");

                nhanVienManager.AddNhanVien(_nv);

                string newName = "A1";

                nhanVienManager.UpdateNhanVien(0, newName);
                Assert.AreEqual(newName, _nv.Name);
            }
            [Test]
            public void Test_Delete_Nhan_Vien()
            {
                //Assert.Pass();

                _nv = new NhanVien(0, "A");

                nhanVienManager.AddNhanVien(_nv);

                nhanVienManager.DeleteNhanVien(2);
                Assert.IsTrue(nhanVienManager.nhanViens.Contains(_nv));
            }

        }
    }

    #endregion
}
    }
}
