using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectDemo;
namespace TestDemo
{
    [TestFixture] //Chỉ ra lớp chứa đoạn code cần test
    public class TestPhanSo
    {
        [Test] //Chỉ ra phương thức test. Phương thức này có kiểu trả về là void và không có tham số kèm theo.
        public void TestPS1()
        {
            int x = 1;
            int y = 2;
            Assert.Equals(x, y);
        }
        [Test]
        public void TestPS2()
        {
            PhanSo ps1 = new PhanSo(1,2);
            PhanSo ps2 = new PhanSo(1,3);
            PhanSo ps3 = new PhanSo(1,4);
            Assert.AreEqual(ps1, ps2);
            Assert.AreNotEqual(ps2, ps3);
        }
    }
}
