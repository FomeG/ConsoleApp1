using Microsoft.SqlServer.Server;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class _0Bai2_Services
    {


    }

    public class Sinhvienpoly
    {
        public Sinhvien _nv;
        public List<Sinhvien> svien = new List<Sinhvien>();

        public List<Sinhvien> timTheoMaLop()
        {
            return new List<Sinhvien>();
        }

        private bool checkLength(string hoten, string malop, string tenlop, string masv)
        {
            if (hoten.Length > 10 || malop.Length > 10 || tenlop.Length > 10 || masv.Length > 10)
            {
                return false;
            }
            return true;
        }
        private bool IsValidTenLop(string tenlop)
        {
            string pattern = @"^[a-zA-Z0-9\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(tenlop, pattern);
        }

        public bool AddSV(Sinhvien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.tenlop) || !IsValidTenLop(sv.tenlop))
            {
                throw new Exception("Tên lớp không hợp lệ. Không được chứa ký tự đặc biệt.");
            }

            if (!checkLength(sv.hoten, sv.malop, sv.tenlop, sv.masv))
            {
                throw new Exception("Độ dài ký tự vượt quá cho phép");
            }

            var svcansua = svien.FirstOrDefault(x => x.masv == sv.masv);
            if (svcansua != null)
            {
                throw new Exception("Bị trùng mã sinh viên");
            }
            else
            {
                svien.Add(sv);
                return true;
            }
        }

        public bool SuaSV(string masv, string hoten, string malop, string tenlop)
        {
            if (string.IsNullOrWhiteSpace(tenlop) || !IsValidTenLop(tenlop))
            {
                throw new Exception("Tên lớp không hợp lệ. Không được chứa ký tự đặc biệt.");
            }

            if (!checkLength(hoten, malop, tenlop, masv))
            {
                throw new Exception("Độ dài ký tự vượt quá cho phép");
            }

            var svcansua = svien.FirstOrDefault(x => x.masv == masv);
            if (svcansua != null)
            {
                svcansua.hoten = hoten;
                svcansua.malop = malop;
                svcansua.tenlop = tenlop;
                return true;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên cần sửa");
            }
        }

        public bool XoaSV(string masv)
        {
            var svcanxoa = svien.FirstOrDefault(x => x.masv == masv);
            if (svcanxoa != null)
            {
                svien.Remove(svcanxoa);
                return true;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên cần xoá");
            }
        }

        public Sinhvien TimSV_Ten(string ten)
        {
            var svcantim = svien.FirstOrDefault(x => x.hoten == ten);
            if (svcantim != null)
            {
                return svcantim;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên");
            }
        }

        public Sinhvien TimSV_MaSV(string masv)
        {
            var svcantim = svien.FirstOrDefault(x => x.masv == masv);
            if (svcantim != null)
            {
                return svcantim;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên");
            }
        }

        public List<Sinhvien> TimSV_MaLop(string malop)
        {
            var svcantim = svien.Where(x => x.malop == malop).ToList();
            if (svcantim != null)
            {
                return svcantim;
            }
            else
            {
                throw new NullReferenceException("Không tìm thấy sinh viên");
            }
        }


    }

    public class Sinhvien
    {
        public string id { get; set; }
        public string hoten { get; set; }
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string masv { get; set; }

        private static int nextId = 1;

        public Sinhvien()
        {
            this.id = "SV" + nextId.ToString();
            nextId++;
        }

        public Sinhvien(string id, string hoten, string malop, string tenlop, string masv)
        {
            this.id = "SV" + nextId.ToString();
            nextId++;

            this.hoten = hoten;
            this.malop = malop;
            this.tenlop = tenlop;
            this.masv = masv;
        }


    }

}
