using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Lab_7_8.Phan_2
{
    public class BaiHat
    {
        public string id { get; set; }
        public string ten { get; set; }
        public string tenCasi { get; set; }
        public int doDai { get; set; }
        public string tenNhacSi { get; set; }

        public BaiHat()
        {

        }
        public BaiHat(string id, string ten, string tenCasi, int doDai, string tenNhacSi)
        {
            this.id = id;
            this.ten = ten;
            this.tenCasi = tenCasi;
            this.doDai = doDai;
            this.tenNhacSi = tenNhacSi;
        }
    }

    public class BaiHatServices
    {
        public bool Them(string id, string ten, string tenCasi, int doDai, string tenNhacSi)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(tenCasi) || string.IsNullOrWhiteSpace(tenNhacSi))
            {
                throw new Exception("Không được để trống");
                return false;
            }
            if (doDai <= 0)
            {
                throw new Exception("Độ dài không hợp lệ");
                return false;
            }
            if (Seeddata.dsbaihat.Any(x => x.id == id.ToLower()))
            {
                throw new Exception("Đã tồn tại bài hát với id: " + id);
                return false;
            }

            BaiHat baihatmoi = new BaiHat(id, ten, tenCasi, doDai, tenNhacSi);
            try
            {
                Seeddata.dsbaihat.Add(baihatmoi);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Xoa(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new Exception("Không được để trống id");
                return false;
            }
            var dtcanxoa = Seeddata.dsbaihat.SingleOrDefault(x => x.id == id);
            if (dtcanxoa == null)
            {
                throw new NullReferenceException("Bài hát không tồn tại");
                return false;
            }

            Seeddata.dsbaihat.Remove(dtcanxoa);
            return true;
            //return true;
        }
    }

    public static class Seeddata
    {
        public static List<BaiHat> dsbaihat = new List<BaiHat>()
        {
            new BaiHat("id1","Baihat1","casi1",20,"Nghia1"),
            new BaiHat("id2","Baihat2","casi2",21,"Nghia2"),
            new BaiHat("id3","Baihat3","casi3",22,"Nghia3"),
            new BaiHat("id4","Baihat4","casi4",23,"Nghia4"),
            new BaiHat("id5","Baihat5","casi5",24,"Nghia5")
        };
    }
}
