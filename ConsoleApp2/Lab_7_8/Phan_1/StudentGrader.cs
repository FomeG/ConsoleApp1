using NUnit.Framework;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Lab_7_8
{
    [TestFixture]
    public class StudentGrader
    {

        [Test]
        // Trường hợp điểm hợp lệ
        [TestCase(10, ExpectedResult = "Xếp loại F")]
        [TestCase(11, ExpectedResult = "Xếp loại F")]
        [TestCase(12, ExpectedResult = "Xếp loại F")]
        [TestCase(15, ExpectedResult = "Xếp loại F")]
        [TestCase(23.3, ExpectedResult = "Xếp loại F")]
        [TestCase(40, ExpectedResult = "Xếp loại F")]
        [TestCase(60, ExpectedResult = "Xếp loại D")]
        [TestCase(80, ExpectedResult = "Xếp loại B")]
        [TestCase(100, ExpectedResult = "Xếp loại A")]

        // Trường hợp điểm không hợp lệ
        [TestCase(120, ExpectedResult = typeof(ArgumentException))]
        [TestCase(140, ExpectedResult = typeof(ArgumentException))]
        [TestCase(-20, ExpectedResult = typeof(ArgumentException))]
        [TestCase(-180, ExpectedResult = typeof(ArgumentException))]
        public string XepLoai(double diemHS)
        {
            if (diemHS >= 0 && diemHS <= 40)
            {
                return "Xếp loại F";
            }
            else if (diemHS > 40 && diemHS <= 60)
            {
                return "Xếp loại D";
            }
            else if (diemHS > 60 && diemHS <= 70)
            {
                return "Xếp loại C";
            }
            else if (diemHS > 70 && diemHS <= 80)
            {
                return "Xếp loại B";
            }
            else if (diemHS > 80 && diemHS <= 100)
            {
                return "Xếp loại A";
            }
            else
            {
                throw new ArgumentException("Điểm không hợp lệ");
            }

        }
    }
}
