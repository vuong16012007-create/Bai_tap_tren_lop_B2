using System;
using System.Collections.Generic;
using System.Text;

namespace bai9
{
    public class XeMay : PhuongTien
    {
        public XeMay(string tenXe, double giaTri) : base(tenXe, giaTri) { }

        public override double TinhTienThue()
        {
            // VAT 10% + Trước bạ 5% = 15% (0.15)
            return GiaTri * 0.15;
        }
        public override void XuatThongTin()
        {
            Console.Write("[Xe Máy]     ");
            base.XuatThongTin();
            Console.WriteLine();
        }
    }
}
