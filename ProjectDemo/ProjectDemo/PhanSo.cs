using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{
    public class PhanSo
    {
        int tu;
        int mau;
        
        public PhanSo()
        {

        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo add(PhanSo ps1)
        {
            PhanSo ps = new PhanSo();
            ps.mau = ps1.mau * mau;
            ps.tu = ps1.tu * mau + ps1.mau * tu;
            return ps;
        }
    }
}
