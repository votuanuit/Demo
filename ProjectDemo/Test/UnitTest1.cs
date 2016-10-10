using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDemo;
namespace Test
{
    [TestClass] // báo cho biết lớp cần để test
    public class UnitTest1
    {
        [TestMethod] //dùng để báo cho Nunit đưa method này vào test case
        public void TestPS1()
        {
            int dukien = 1;
            int thucte = 2;
            Assert.AreNotEqual(dukien, thucte);
        }
        [TestMethod]
        public void TestPS2()
        {
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(1, 4);
            PhanSo ps3 = new PhanSo(1, 4);
            PhanSo add = ps2.add(ps3);
            Assert.AreNotEqual(ps1, add);
            
        }
    }
}
