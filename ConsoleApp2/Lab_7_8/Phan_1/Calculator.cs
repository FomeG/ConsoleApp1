using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Lab_7_8
{
    [TestFixture]
    public class Calculator
    {
        [Test]
        // a,b : 1 - 10
        // Trường hợp đúng
        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(1, 10, ExpectedResult = 10)]
        [TestCase(1, 9, ExpectedResult = 9)]
        [TestCase(1, 8, ExpectedResult = 8)]
        [TestCase(1, 3, ExpectedResult = 3)]
        [TestCase(10, 2, ExpectedResult = 20)]
        [TestCase(9, 1, ExpectedResult = 9)]
        [TestCase(8, 2, ExpectedResult = 16)]
        [TestCase(3, 1, ExpectedResult = 3)]

        // Trường hợp sai
        [TestCase(1, "ok", ExpectedResult = typeof(ArithmeticException))]
        [TestCase(1, 90, ExpectedResult = typeof(ArithmeticException))]
        [TestCase("ok", 4, ExpectedResult = typeof(ArithmeticException))]
        [TestCase(-2, 4, ExpectedResult = typeof(ArithmeticException))]
        public int phepnhan(object a, object b)
        {
            if (!int.TryParse(a.ToString(), out int a1) || !int.TryParse(b.ToString(), out int b1))
            {
                throw new ArithmeticException("Số nhập vào phải là số nguyên");
            }
            else if (a1 < 1 || a1 > 10 || b1 < 1 || b1 > 10)
            {
                throw new Exception("Giá trị nhập vào phải thuộc khoảng từ 1 - 10");
            }

            return a1 * b1;
        }


        [Test]
        // Trường hợp ngoại lệ
        [TestCase(10, 0, ExpectedResult = typeof(ArithmeticException))]
        [TestCase(99, 0, ExpectedResult = typeof(ArithmeticException))]
        [TestCase(188, "ok", ExpectedResult = typeof(ArithmeticException))]
        [TestCase("ok", 3, ExpectedResult = typeof(ArithmeticException))]

        // Trường hợp B khác 0
        [TestCase(11, 2, ExpectedResult = 5.5)]
        [TestCase(12, 2, ExpectedResult = 6)]
        [TestCase(13, 2, ExpectedResult = 6.5)]
        [TestCase(14, 2, ExpectedResult = 7)]
        [TestCase(15, 2, ExpectedResult = 7.5)]
        [TestCase(16, 2, ExpectedResult = 8)]
        [TestCase(20, 2, ExpectedResult = 10)]
        [TestCase(40, 5, ExpectedResult = 8)]
        [TestCase(60, 10, ExpectedResult = 6)]
        [TestCase(80, 20, ExpectedResult = 4)]
        public double phepchia(object a, object b)
        {
            if (!double.TryParse(a.ToString(), out double a1) || !double.TryParse(b.ToString(), out double b1))
            {
                throw new ArithmeticException("Số nhập vào phải là số nguyên");
            }
            if (b1 == 0)
            {
                throw new ArithmeticException("Không được phép chia cho 0");
            }
            else
            {
                return a1 / b1;
            }
        }
    }
}
