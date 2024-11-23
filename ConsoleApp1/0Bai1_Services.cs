using System;

namespace ConsoleApp1.Bai1_Test
{
    public class Bai1_Services
    {
        public static void Main(string[] args)
        {

        }
        public int tong(object a, object b)
        {
            if (a == null || b == null)
            {
                throw new Exception("Không được để trống");
            }

            if (int.TryParse(a.ToString(), out int c) && int.TryParse(b.ToString(), out int d))
            {
                //Console.WriteLine("Đây là 1 số nguyên");
                if (c > 10 || d > 10 || c < 0 || d < 0)
                {
                    throw new Exception("giá trị nhập vào chỉ từ 0 -> 10");
                }
                return c + d;
            }
            throw new Exception("Đây không phải là số nguyên");
        }

        public int hieu(object a, object b)
        {
            if (a == null || b == null)
            {
                throw new Exception("Không được để trống");
            }

            if (int.TryParse(a.ToString(), out int c) && int.TryParse(b.ToString(), out int d))
            {
                //Console.WriteLine("Đây là 1 số nguyên");
                if (c > 10 || d > 10 || c < 0 || d < 0)
                {
                    throw new Exception("giá trị nhập vào chỉ từ 0 -> 10");
                }
                return c - d;
            }
            throw new Exception("Đây không phải là số nguyên");
        }

        public int tich(object a, object b)
        {
            if (a == null || b == null)
            {
                throw new Exception("Không được để trống");
            }

            if (int.TryParse(a.ToString(), out int c) && int.TryParse(b.ToString(), out int d))
            {
                //Console.WriteLine("Đây là 1 số nguyên");
                if (c > 10 || d > 10 || c < 0 || d < 0)
                {
                    throw new Exception("giá trị nhập vào chỉ từ 0 -> 10");
                }
                return c * d;
            }
            throw new Exception("Đây không phải là số nguyên");
        }

        public double TBC(int[] dayso, int? chia)
        {
            // Trong trường hợp dãy số bị trống => trả về exception
            if (dayso.Length == 0)
            {
                throw new Exception("Dãy số không được trống.");
            }

            if (!chia.HasValue || chia == 0)
            {
                throw new Exception("Không chia được cho 0.");
            }


            // Truowngf hợp dãy số không trống => tính tổng
            int tong = 0;
            foreach (int so in dayso)
            {
                tong += so;
            }

            return (double)tong / chia.Value;
        }


        public void truyXuatPhanTu()
        {

        }

    }
}
